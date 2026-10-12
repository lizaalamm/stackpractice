using System;
using System.Collections.Generic;
using Npgsql;
using Models;

namespace DataAccessLayer
{
    public class crud
    {
        public static List<ProductModel> GetAllData()
        {
            List<ProductModel> products = new List<ProductModel>();
            string query = "select * from \"Products\"";

            using (NpgsqlConnection connection = dbhelper.GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductModel model = new ProductModel();
                        model.Id = Convert.ToInt32(reader["Id"]);
                        model.Name = reader["Name"].ToString() ?? string.Empty;
                        products.Add(model);
                    }
                }
            }

            return products;
        }
    }
}