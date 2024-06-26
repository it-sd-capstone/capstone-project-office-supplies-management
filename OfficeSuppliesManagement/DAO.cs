﻿using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSuppliesManagement
{
    public class DAO
    {
       
        private string connStr = "server=localhost;user=root;port=3306;password=mysql";

        
        public string ConnStr => connStr;

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            
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
            finally
            {
                conn.Close();
                Console.WriteLine("Done.");
            }
            return products;
        }
        public DataTable GetAllProductsAsDataTable()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Products"; 
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

    }
}
