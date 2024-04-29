﻿using MySql.Data.MySqlClient;
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
        public AddProductForm()
        {
            InitializeComponent();
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

                    //Success message and clear the text boxes
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtDescription.Clear();
                    txtPrice.Clear();
                    txtQuantity.Clear();
                    txtCategoryId.Clear();
                    conn.Close();
                }
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;
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
    }
}
