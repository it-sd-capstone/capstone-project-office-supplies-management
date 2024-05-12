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


        public AddProductForm()
        {
            InitializeComponent();
            lblCategoryDescText.MaximumSize = new Size(cbCategoryId.Width, 0);
        }


        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtDescription.Text.Trim()) ||
                string.IsNullOrEmpty(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtQuantity.Text.Trim()) ||
                cbCategoryId.SelectedIndex < 0)
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

            if (cbCategoryId.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd.Parameters.AddWithValue("_categoryId", int.Parse(cbCategoryId.SelectedValue.ToString()));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        //clear the text boxes
                        clearTxts();

                        conn.Close();
                    }

                    // Show success message in the label instead of a message box
                    lblSuccessMessage.Visible = true;
                }

                // Clear the newly entered data.
                clearTxts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            lblSuccessMessage.Visible = false; // Hide it initially

            // Initialize a database connection.
            var dao = new DAO();
            string sql = "SELECT categoryId, categoryName FROM categories;";
            var conn = new MySqlConnection(dao.ConnStr);
            var cmd = new MySqlCommand(sql, conn);
            var da = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            // Populate the ComboBox.
            cbCategoryId.DataSource = dt;
            cbCategoryId.DisplayMember = "categoryName";
            cbCategoryId.ValueMember = "categoryId";

            // Clear TextBoxes before populating the ProductId TextBox.
            clearTxts();

            updateProductId();
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

        private void updateProductId()
        {
            // Get the ID number of the last product in the table, then add one 
            // to simulate what the ID of the product that the user is about to 
            // add will be.
            var dao = new DAO();
            string sql = "SELECT MAX(productId) FROM products";
            var conn = new MySqlConnection(dao.ConnStr);
            var cmd = new MySqlCommand(sql, conn);
            cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int.TryParse(cmd.ExecuteScalar().ToString(), out int maxId);
            conn.Close();
            txtProductId.Text = (maxId + 1).ToString();
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

            // Hide the success label again.
            lblSuccessMessage.Visible = false;

            // Update the simulated new product ID after everything has 
            // been reset.
            updateProductId();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTxts();
            lblCategoryDescText.Text = "*";
        }
    }
}
