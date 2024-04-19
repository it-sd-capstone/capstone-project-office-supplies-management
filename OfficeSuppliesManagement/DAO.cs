using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSuppliesManagement
{
    internal class DAO
    { 

        // **********************************************************
        // *** Function to test the connection with the database. ***
        // **********************************************************
        //
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            // Connect to the database
            string connStr = "server=localhost;user=root;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "CREATE DATABASE IF NOT EXISTS OfficeSupplies;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return products;
        }
    }
}
