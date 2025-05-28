//#8
//using System;
//using Microsoft.Data.SqlClient;
//class Exercise8
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            using (SqlCommand cmd = new SqlCommand("CustOrderHist", conn))
//            {
//                cmd.CommandType = System.Data.CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@CustomerID", "ALFKI");
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                    while (reader.Read())
//                        Console.WriteLine($"{reader["ProductName"]} | {reader["Total"]}");
//            }
//        }
//    }
//}