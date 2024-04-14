using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSuppliesManagement
{
    internal class DAO
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OfficeSupplies;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    
        // **********************************************************
        // *** Function to test the connection with the database. ***
        // **********************************************************
        //
        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();

            // Connect to the database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create test command
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Products", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product p = new Product
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Price = (float) reader.GetDecimal(3),
                        Quantity = reader.GetInt16(4),
                        CategoryID = reader.GetInt16(5)
                    };

                    // Append each product to the product list.
                    products.Add(p);
                }
            }
            connection.Close();

            return products;
        }
    }
}
