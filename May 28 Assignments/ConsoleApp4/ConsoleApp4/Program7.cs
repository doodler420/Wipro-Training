
//#7
//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;
//class Exercise7
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            string query = @"
//        SELECT p.CategoryID, SUM(od.UnitPrice * od.Quantity) AS TotalSales
//        FROM [Order Details] od
//        JOIN Products p ON od.ProductID = p.ProductID
//        GROUP BY p.CategoryID";
//            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
//            {
//                DataTable dt = new DataTable();
//                adapter.Fill(dt);
//                foreach (DataRow row in dt.Rows)
//                    Console.WriteLine($"{row["CategoryID"]} | {row["TotalSales"]}");
//            }
//        }
//    }
//}