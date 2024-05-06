using MySql.Data.MySqlClient;
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
                    using (var cmd = new MySqlCommand("DisplayProductSupplier", conn))
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

        private void DisplayProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            OfficeSuppliesManagement optionsForm = new OfficeSuppliesManagement();
            optionsForm.ShowDialog();
        }

        private void btnBackDisplayProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficeSuppliesManagement mainForm = new OfficeSuppliesManagement();
            mainForm.Show();
        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
