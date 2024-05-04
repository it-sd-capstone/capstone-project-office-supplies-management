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
using System.Xml.Linq;

namespace OfficeSuppliesManagement
{
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private Product? product;
        

        /*
        Changed some of the code below so that the user can specify which product to update using the ProductID.
        Next week I'll work on the user interface to actually display all of the products so that the user can see
        all products and their ID's - AB 4/28/2024
        */
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text.Trim()) || string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtDescription.Text.Trim()) ||
                string.IsNullOrEmpty(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtQuantity.Text.Trim()) ||
                string.IsNullOrEmpty(txtCategoryId.Text.Trim()))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var input = txtProductId.Text.Trim();
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int productId) || productId <= 0)
            {
                MessageBox.Show("Please enter a valid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DAO dao = new DAO();
            try
            {
                using (var conn = new MySqlConnection(dao.ConnStr))
                {
                    // Calls UpdateProduct SP to update a product
                    using (var cmd = new MySqlCommand("UpdateProduct", conn))
                    {
                        //Need to add text box controls for the underlined
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_productId", productId);
                        cmd.Parameters.AddWithValue("_name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("_description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("_price", decimal.Parse(txtPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("_quantity", int.Parse(txtQuantity.Text.Trim()));
                        cmd.Parameters.AddWithValue("_categoryId", int.Parse(txtCategoryId.Text.Trim()));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        //Success message and clear the text boxes
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtDescription.Clear();
                        txtPrice.Clear();
                        txtQuantity.Clear();
                        txtCategoryId.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;
        }

        private void UpdateProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            OfficeSuppliesManagement optionsForm = new OfficeSuppliesManagement();
            optionsForm.ShowDialog();
        }

        private void btnBackUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficeSuppliesManagement mainForm = new OfficeSuppliesManagement();
            mainForm.Show();
        }
    }
}
