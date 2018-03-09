using CSAT_.App_Code.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CSAT_.App_Code
{
    public static class Connection
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        static Connection()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["CSATConnection"].ToString();
            conn = new SqlConnection(connectionString);
            command = new SqlCommand("", conn);
        }

        public static ArrayList GetFoodByType(string foodType)
        {
            ArrayList list = new ArrayList();
            string query = string.Format("SELECT * FROM food WHERE type LIKE '{0}'", foodType);

            try
            {
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string type = reader.GetString(2);
                    double price = reader.GetDouble(3);
                    string image = (reader.IsDBNull(4)) ? "" : reader.GetString(4);
                    string ingredient = (reader.IsDBNull(5)) ? "" : reader.GetString(5);
                    string description = (reader.IsDBNull(6)) ? "" : reader.GetString(6);

                    Food_Type fType = (Food_Type)Enum.Parse(typeof(Food_Type), type, true);

                    Food food = new Food(id, name, fType, price, image, ingredient, description);
                    list.Add(food);
                }
            }
            finally
            {
                conn.Close();
            }

            return list;
        }

        public static void AddFood(Food food)
        {
            string query = string.Format(
                @"INSERT INTO food VALUES ('{0}', '{1}', @price, '{2}', '{3}', '{4}')",
                food.Name, food.Type, food.Image, food.Ingredient, food.Description);
            command.CommandText = query;
            command.Parameters.Add(new SqlParameter("price", food.Price));
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
                command.Parameters.Clear();
            }
        }
    }
}