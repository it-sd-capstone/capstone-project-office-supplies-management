using Microsoft.Data.SqlClient;
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
            lblCategoryDescText.MaximumSize = new Size(700, 0);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OfficeSuppliesManagement.HandleFormKeyboardShortcuts);
            this.StartPosition = FormStartPosition.Manual;
         
        }

        //Adding for tests
        public void SetProductDetails(int productId, string name, string description, decimal price, int quantity, int categoryId)
        {
            txtProductId.Text = productId.ToString();
            txtName.Text = name;
            txtDescription.Text = description;
            txtPrice.Text = price.ToString();
            txtQuantity.Text = quantity.ToString();
            cbCategoryId.SelectedValue = categoryId.ToString();
        }

        /*
        Changed some of the code below so that the user can specify which product to update using the ProductID.
        Next week I'll work on the user interface to actually display all of the products so that the user can see
        all products and their ID's - AB 4/28/2024
        */
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text.Trim()) || string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtDescription.Text.Trim()) ||
                string.IsNullOrEmpty(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtQuantity.Text.Trim()) ||
                cbCategoryId.SelectedIndex < 0)
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

            if (cbCategoryId.SelectedIndex < 0)
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
                        cmd.Parameters.AddWithValue("_categoryId", int.Parse(cbCategoryId.SelectedValue.ToString()));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        // Show success message in the label instead of a message box
                        lblSuccessMessage.Visible = true;

                        //clear the text boxes
                        clearTxts();
                    }

                    // Show success message in the label instead of a message box
                    lblSuccessMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            lblSuccessMessage.Visible = false; // Hide it initially

            txtName.Enabled = false;
            txtDescription.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
            cbCategoryId.Enabled = false;

            // Initialize a database connection.
            var dao = new DAO();
            string sql = "SELECT categoryId, categoryName FROM categories;";
            var conn = new MySqlConnection(dao.ConnStr);
            var cmd = new MySqlCommand(sql, conn);
            var da = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            // Populate the ComboBox
            cbCategoryId.DataSource = dt;
            cbCategoryId.DisplayMember = "categoryName";
            cbCategoryId.ValueMember = "categoryId";

            clearTxts();
        }

        private void cbCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoryId.SelectedIndex >= 0)
            {
                var dao = new DAO();
                string sql = "SELECT description FROM categories WHERE categoryId=@categoryId";
                var conn = new MySqlConnection(dao.ConnStr);
                var cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@categoryId", cbCategoryId.SelectedValue.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblCategoryDescText.Text = reader[0].ToString();
                }
                conn.Close();

                if (lblCategoryDescText.Text == "")
                {
                    lblCategoryDescText.Text = "*";
                }
            }
        }

        private void btnDisplayProdInfo_Click(object sender, EventArgs e)
        {
            // Check for valid input.
            if (!int.TryParse(txtProductId.Text, out var input))
            {
                MessageBox.Show("Please enter a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTxts();
                txtProductId.Focus();
                return;
            }

            var dao = new DAO();
            var conn = new MySqlConnection(dao.ConnStr);
            MySqlCommand checkProdId = new MySqlCommand("SELECT * FROM products WHERE productId=@productId", conn);
            conn.Open();
            checkProdId.Parameters.AddWithValue("@productId", txtProductId.Text);
            MySqlDataReader checkRows = checkProdId.ExecuteReader();

            // If the product ID number the user provides is in the database and valid...
            if (checkRows.HasRows)
            {
                // Setup database connection and query string.
                try
                {
                    dao = new DAO();
                    string sql = $"SELECT name, description, price, quantity, categoryId FROM products WHERE productId=@productId";
                    conn = new MySqlConnection(dao.ConnStr);
                    var cmd = new MySqlCommand(sql, conn);

                    // Open connection and finish making the query string.
                    conn.Open();
                    cmd.Parameters.AddWithValue("@productId", txtProductId.Text);

                    // Read query data.
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int.TryParse(reader[4].ToString(), out int catId);

                        txtName.Text = reader[0].ToString();
                        txtDescription.Text = reader[1].ToString();
                        txtPrice.Text = reader[2].ToString();
                        txtQuantity.Text = reader[3].ToString();
                        cbCategoryId.SelectedIndex = catId - 1;  // Subtract one for 0-based indexing
                    }

                    txtName.Enabled = true;
                    txtDescription.Enabled = true;
                    txtPrice.Enabled = true;
                    txtQuantity.Enabled = true;
                    cbCategoryId.Enabled = true;

                }
                catch (Exception ex)
                {
                    clearTxts();
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else  // The product ID number the user provides is not in the database...
            {
                MessageBox.Show("This product ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTxts();
                txtProductId.Focus();
                return;
            }

            conn.Close();
        }

        private void clearTxts()
        {
            // Clear all of the TextBoxes.
            txtProductId.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cbCategoryId.SelectedIndex = -1;

            // Revert to only the ProductId TextBox being enabled.
            txtProductId.Enabled = true;
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
            cbCategoryId.Enabled = false;

            // Hide the success label again.
            lblSuccessMessage.Visible = false;

            lblCategoryDescText.Text = "*";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Except(new Form[] { this, OfficeSuppliesManagement.mainForm }).ToList().ForEach(f => f.Close());
            this.Close();
            OfficeSuppliesManagement.mainForm.Show();
        }
    }
}
