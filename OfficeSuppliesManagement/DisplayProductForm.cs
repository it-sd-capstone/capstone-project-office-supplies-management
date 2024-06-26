﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace OfficeSuppliesManagement
{
    public partial class DisplayProductForm : Form
    {
        public DisplayProductForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OfficeSuppliesManagement.HandleFormKeyboardShortcuts);
            this.StartPosition = FormStartPosition.Manual;
           
        }
        private void InitializeDataGridView()
        {

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = true;
            dgv.CellMouseClick += new DataGridViewCellMouseEventHandler(dgv_CellMouseClick);
        }
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift) && e.RowIndex >= 0)
            {

                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void btnDisplayProductSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text.Trim()))
            {
                MessageBox.Show("Please enter a product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtProductId.Text.Trim(), out int productId) || productId <= 0)
            {
                MessageBox.Show("Please enter a valid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DAO dao = new DAO();
            try
            {
                using (var conn = new MySqlConnection(dao.ConnStr))
                {
                    using (var cmd = new MySqlCommand("DisplayProductDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_productId", productId);
                        conn.Open();
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        if (dt.Rows.Count > 0)
                        {
                            dgv.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No data found for the provided ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            DataTable dt = dao.GetAllProductsAsDataTable();
            string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "AllProducts.pdf");

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            table.WidthPercentage = 100;


            foreach (DataColumn column in dt.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }


            foreach (DataRow row in dt.Rows)
            {
                foreach (Object item in row.ItemArray)
                {
                    table.AddCell(new Phrase(item.ToString()));
                }
            }

            document.Add(table);
            document.Close();

            MessageBox.Show("PDF created on your desktop.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            try
            {
                using (var conn = new MySqlConnection(dao.ConnStr))
                {
                    string query = "SELECT productID, name, description, price, quantity, categoryId, SupplierID FROM products";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        if (dt.Rows.Count > 0)
                        {
                            dgv.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No products found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Except(new Form[] { this, OfficeSuppliesManagement.mainForm }).ToList().ForEach(f => f.Close());
            this.Close();
            OfficeSuppliesManagement.mainForm.Show();

        }
    }
}
