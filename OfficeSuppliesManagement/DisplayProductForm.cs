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
            DAO dao = new DAO();
            using (var conn = new MySqlConnection(dao.ConnStr))
            {
                // Calls DisplayProductSupplier SP to display product info
                using (var cmd = new MySqlCommand("DisplayProductSupplier", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //User would enter productID into a text box
                    cmd.Parameters.AddWithValue("_productId", int.Parse(txtProductId.Text));
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Process each record
                           
                        }
                    }
                    conn.Close();
                }
            }
        }
    }
}
