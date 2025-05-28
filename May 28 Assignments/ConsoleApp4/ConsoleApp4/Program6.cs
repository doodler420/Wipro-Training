
//#6
//using System;
//using Microsoft.Data.SqlClient;
//class Exercise6
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            string query = @"
//        SELECT o.OrderID, c.CompanyName, o.OrderDate
//        FROM Orders o
//        INNER JOIN Customers c ON o.CustomerID = c.CustomerID";
//            using (SqlCommand cmd = new SqlCommand(query, conn))
//            using (SqlDataReader reader = cmd.ExecuteReader())
//                while (reader.Read())
//                    Console.WriteLine($"{reader["OrderID"]} | {reader["CompanyName"]} | {reader["OrderDate"]}");
//        }
//    }
//}
