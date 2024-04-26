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
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            using (var conn = new MySqlConnection(dao.ConnStr))
            {
                // Calls AddNewProduct SP to add a new product
                using (var cmd = new MySqlCommand("AddNewProduct", conn))
                {
                    //Need to add text box controls for the underlined
                    cmd.CommandType = CommandType.StoredProcedure;
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

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            OfficeSuppliesManagement optionsForm = new OfficeSuppliesManagement();
            optionsForm.ShowDialog();
        }
    }
}
