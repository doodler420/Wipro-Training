using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // 1. Instantiate the connection
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            // 2. Open the connection
            conn.Open();

            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("select ContactName,City,CompanyName from Customers", conn);

            //
            // 4. Use the connection
            //

            // get query results
                        rdr = cmd.ExecuteReader();
            Console.WriteLine("Contact Name\t\t\t\t\tCity\t\t\t\t\tCompany Name");
            Console.WriteLine("------------\t\t\t\t\t----\t\t\t\t\t-------------");
            // print the CustomerID of each record
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0].ToString().Trim().PadRight(25) +
                "\t\t\t" + rdr[1].ToString().Trim().PadRight(20) +
                "\t\t\t" + rdr[2].ToString().Trim().PadRight(30));
//answer
//                 // 1. get an instance of the SqlDataReader
// rdr = cmd.ExecuteReader();

// // print a set of column headers
// Console.WriteLine("Contact Name    City    Company Name");
// Console.WriteLine("______");

// // 2. print necessary columns of each record
// while (rdr.Read())
// {
//     // get the results of each column
//     string contact = (string)rdr["ContactName"];
//     string company = (string)rdr["CompanyName"];
//     string city = (string)rdr["City"];
//     // print out the results
//     Console.Write("{0,-25}", contact);
//     Console.Write("{0,-20}", city);
//     Console.Write("{0,-25}", company);
//     Console.WriteLine();
// }
            }
        }
        catch
        {

        }
        finally
        {
            // close the reader
            if (rdr != null)
            {
                rdr.Close();
            }

            // 5. Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
//string connectionString =
//           "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
//           "Integrated Security=true";

//// Provide the query string with a parameter placeholder.
//string queryString =
//    "SELECT ProductID, UnitPrice, ProductName from dbo.products " +
//    "WHERE UnitPrice > @pricePoint " +
//    "ORDER BY UnitPrice DESC;";

//// Specify the parameter value.
//int paramValue = 5;

//// Create and open the connection in a using block.
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    // Create the Command and Parameter objects.
//    SqlCommand command = new SqlCommand(queryString, connection);
//    command.Parameters.AddWithValue("@pricePoint", paramValue);

//    try
//    {
//        connection.Open();
//        SqlDataReader reader = command.ExecuteReader();
//        while (reader.Read())
//        {
//            Console.WriteLine("\t{0}\t{1}\t{2}",
//                reader[0], reader[1], reader[2]);
//        }
//        reader.Close();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    Console.ReadLine();
//}


//#2
//1.Instantiate the connection
//SqlConnection conn = new SqlConnection(
//    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

//SqlDataReader rdr = null;

//try
//{
    // 2. Open the connection
//    conn.Open();

//    // 3. Pass the connection to a command object
//    SqlCommand cmd = new SqlCommand("select * from Customers", conn);

//    // 4. Use the connection
//    // get query results
//    rdr = cmd.ExecuteReader();

//    // print the CustomerID of each record
//    while (rdr.Read())
//    {
//        Console.WriteLine(rdr[1]);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Error: " + ex.Message);
//}
//finally
//{
//    // close the reader
//    if (rdr != null)
//    {
//        rdr.Close();
//    }
//    // 5. Close the connection
//    if (conn != null)
//    {
//        conn.Close();
//    }
//}