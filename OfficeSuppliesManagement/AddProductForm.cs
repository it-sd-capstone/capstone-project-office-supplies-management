using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OfficeSuppliesManagement
{
    public partial class AddProductForm : Form
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductCategoryId { get; set; }
        
        private Label lblSuccessMessage;

        private ComboBox cbCategory;

        public AddProductForm()
        {
            InitializeComponent();

            // Initialize success message label
            lblSuccessMessage = new Label();
            lblSuccessMessage.ForeColor = Color.Green;
            lblSuccessMessage.Visible = false; // Hide it initially
            this.Controls.Add(lblSuccessMessage);

            // Initialize category combo box
            cbCategory = new ComboBox();
            this.Controls.Add(cbCategory); // Add it to the form
        }


        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtDescription.Text.Trim()) ||
                string.IsNullOrEmpty(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtQuantity.Text.Trim()) ||
                string.IsNullOrEmpty(txtCategoryId.Text.Trim()))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCategoryId.Text.Trim(), out int categoryId) || categoryId <= 0)
            {
                MessageBox.Show("Please enter a valid category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                DAO dao = new DAO();
                using (var conn = new MySqlConnection(dao.ConnStr))
                {
                    // Calls AddNewProduct SP to add a new product
                    using (var cmd = new MySqlCommand("AddNewProduct", conn))
                    {
                        //Need to add text box controls for the underlined
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("_description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("_price", decimal.Parse(txtPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("_quantity", int.Parse(txtQuantity.Text.Trim()));
                        cmd.Parameters.AddWithValue("_categoryId", int.Parse(txtCategoryId.Text.Trim()));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        //clear the text boxes
                        txtName.Clear();
                        txtDescription.Clear();
                        txtPrice.Clear();
                        txtQuantity.Clear();
                        txtCategoryId.Clear();
                        conn.Close();
                    }
                    // Show success message in the label instead of a message box
                    lblSuccessMessage.Text = "Product added successfully!";
                    lblSuccessMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;

            categoryListBox.Items.Clear();

            // Populate the ComboBox
            var dao = new DAO();
            string sql = "SELECT categoryId, categoryName FROM categories;";
            var conn = new MySqlConnection(dao.ConnStr);
            var cmd = new MySqlCommand(sql, conn);
            var da = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "categoryName";
            cbCategory.ValueMember = "categoryId";

            lblCategoryDescIdNum.Text = cbCategory.SelectedValue.ToString();
        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            OfficeSuppliesManagement optionsForm = new OfficeSuppliesManagement();
            optionsForm.ShowDialog();
        }

        private void btnBackAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficeSuppliesManagement mainForm = new OfficeSuppliesManagement();
            mainForm.Show();
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCategoryDescIdNum.Text = cbCategory.SelectedValue.ToString();
        }

        private void categoryListBox_DoubleClick(object sender, EventArgs e)
        {
            var dao = new DAO();
            string sql = $"SELECT description FROM categories WHERE categoryId = {categoryListBox.SelectedValue}";
            var conn = new MySqlConnection(dao.ConnStr);
            var cmd = new MySqlCommand(sql, conn);

            conn.Open();
            string? description = cmd.ExecuteScalar().ToString();
            conn.Close();

            if (description == "")
            {
                description = "(No Description Provided)";
            }

            MessageBox.Show(description, "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
