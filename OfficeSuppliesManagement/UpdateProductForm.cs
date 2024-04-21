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
            DAO dao = new DAO();
            using (var conn = new MySqlConnection(dao.ConnStr)) 
            
            {
                // Calls UpdateProduct SP to update a product
                using (var cmd = new MySqlCommand("UpdateProduct", conn))
                {
                    //Need to add text box controls for the underlined
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_productId", int.Parse(txtProductId.Text));
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
    }