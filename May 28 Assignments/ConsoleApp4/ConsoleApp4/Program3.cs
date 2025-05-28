
////#3

//using System;
//using Microsoft.Data.SqlClient;
//class Exercise3
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            string query = @"
//        INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
//        VALUES (@name, @supplier, @category, @price)";
//            using (SqlCommand cmd = new SqlCommand(query, conn))
//            {
//                cmd.Parameters.AddWithValue("@name", "Test Product");
//                cmd.Parameters.AddWithValue("@supplier", 1);
//                cmd.Parameters.AddWithValue("@category", 1);
//                cmd.Parameters.AddWithValue("@price", 25m);
//                cmd.ExecuteNonQuery();
//            }
//        }
//    }
//}