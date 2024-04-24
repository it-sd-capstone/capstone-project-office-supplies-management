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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;
        }

        private void btnDisplayProductSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please enter a product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtProductId.Text, out int productId) || productId < 0)
            {
                MessageBox.Show("Please enter a valid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DAO dao = new DAO();
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
