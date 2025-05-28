////#2

//using System;
//using Microsoft.Data.SqlClient;
//class Exercise2
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        GetOrdersByCustomer("ALFKI", connectionString);
//    }
//    static void GetOrdersByCustomer(string customerId, string connectionString)
//    {
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            string query = "SELECT OrderID, OrderDate FROM Orders WHERE CustomerID = @customerId";
//            using (SqlCommand cmd = new SqlCommand(query, conn))
//            {
//                cmd.Parameters.AddWithValue("@customerId", customerId);
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                    while (reader.Read())
//                        Console.WriteLine($"{reader["OrderID"]} | {reader["OrderDate"]}");
//            }
//        }
//    }
//}
