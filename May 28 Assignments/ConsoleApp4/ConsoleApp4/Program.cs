using System;
using Microsoft.Data.SqlClient;
class Program
{
    static void Main(string[] args)
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; //Initial Catalog=Northwind;
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected to Northwind database.\n");
                string query = "SELECT CustomerID, CompanyName, Country FROM Customers";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["CustomerID"].ToString();
                    string name = reader["CompanyName"].ToString();
                    string country = reader["Country"].ToString();
                    Console.WriteLine($"{id} | {name} | {country}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

