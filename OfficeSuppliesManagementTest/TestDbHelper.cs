using MySql.Data.MySqlClient;
using OfficeSuppliesManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OfficeSuppliesManagementTest
{
    internal class TestDbHelper
    {
        private static string connStr = "server=localhost;user=root;port=3306;password=mysql;database=OfficeSupplies";

        public static Product GetLastAddedProduct()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM Products ORDER BY productId DESC LIMIT 1", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Product
                        {
                            ProductId = reader.GetInt32("productId"),
                            Name = reader.GetString("name"),
                            Description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                            Price = reader.GetDecimal("price"),
                            Quantity = reader.GetInt32("quantity"),
                            CategoryId = reader.GetInt32("categoryId")
                        };
                    }
                }
            }
            return null; 
        }
        public static Product GetProductById(int productId)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM Products WHERE productId = @productId", conn);
                cmd.Parameters.AddWithValue("@productId", productId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Product
                        {
                            ProductId = reader.GetInt32("productId"),
                            Name = reader.GetString("name"),
                            Description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                            Price = reader.GetDecimal("price"),
                            Quantity = reader.GetInt32("quantity"),
                            CategoryId = reader.GetInt32("categoryId")
                        };
                    }
                }
            }
            return null;
        }
    }
}
