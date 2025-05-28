//#5

//using System;
//using Microsoft.Data.SqlClient;
//class Exercise5
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            string query = "DELETE FROM Products WHERE ProductID = @id";
//            using (SqlCommand cmd = new SqlCommand(query, conn))
//            {
//                cmd.Parameters.AddWithValue("@id", 9999); // Replace with actual ProductID to delete
//                cmd.ExecuteNonQuery();
//            }
//        }
//    }
//}