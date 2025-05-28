//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;
//class Exercise10
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            string query = "SELECT * FROM Products";
//            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
//            {
//                DataSet ds = new DataSet();
//                adapter.Fill(ds, "Products");
//                foreach (DataRow row in ds.Tables["Products"].Rows)
//                {
//                    if (Convert.ToInt32(row["UnitsInStock"]) > 20)
//                        Console.WriteLine($"{row["ProductID"]} | {row["ProductName"]} | {row["UnitsInStock"]}");
//                }
//            }
//        }
//    }
//}
