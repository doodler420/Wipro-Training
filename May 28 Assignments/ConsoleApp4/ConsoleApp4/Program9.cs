
//#9
//using System;
//using Microsoft.Data.SqlClient;
//class Exercise9
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True";
//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            SqlTransaction transaction = conn.BeginTransaction();
//            try
//            {
//                string insertOrder = @"
//          INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, ShipCountry)
//          VALUES ('ALFKI', 1, GETDATE(), 'Germany');
//          SELECT CAST(scope_identity() AS int);";
//                int newOrderId;
//                using (SqlCommand cmd = new SqlCommand(insertOrder, conn, transaction))
//                {
//                    newOrderId = (int)cmd.ExecuteScalar();
//                }
//                string insertOrderDetails = @"
//          INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
//          VALUES (@orderId, 1, 10.0, 5, 0)";
//                using (SqlCommand cmd = new SqlCommand(insertOrderDetails, conn, transaction))
//                {
//                    cmd.Parameters.AddWithValue("@orderId", newOrderId);
//                    cmd.ExecuteNonQuery();
//                }
//                transaction.Commit();
//            }
//            catch
//            {
//                transaction.Rollback();
//            }
//        }
//    }
//}