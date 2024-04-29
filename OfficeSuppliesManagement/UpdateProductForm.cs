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

        private void updateButton_Click(object sender, EventArgs e)
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
                        cmd.Parameters.AddWithValue("_productId", int.Parse(lblProductId.Text));
                        cmd.Parameters.AddWithValue("_name", txtName.Text);
                        cmd.Parameters.AddWithValue("_description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("_price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("_quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("_categoryId", int.Parse(txtCategoryId.Text));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ProductName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string ProductDescription
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        public string ProductPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        public string ProductQuantity
        {
            get { return txtQuantity.Text; }
            set { txtQuantity.Text = value; }
        }

        public string ProductCategoryId
        {
            get { return txtCategoryId.Text; }
            set { txtCategoryId.Text = value; }
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
    }
}
