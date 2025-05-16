class Program
{
    static void Main()
    {
        string connectionString = 
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        // Provide the query string with a parameter placeholder.
        string queryString = 
            "SELECT ProductID, UnitPrice, ProductName from dbo.products " +
            "WHERE UnitPrice > @pricePoint " +
            "ORDER BY UnitPrice DESC;";

        // Specify the parameter value.
        int paramValue = 5;

        // Create and open the connection in a using block.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);
            
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}", 
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
 // 1. Instantiate the connection
        // SqlConnection conn = new SqlConnection(
        //     "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");
        
        // SqlDataReader rdr = null;

        // try
        // {
        //     // 2. Open the connection
        //     conn.Open();
            
        //     // 3. Pass the connection to a command object
        //     SqlCommand cmd = new SqlCommand("select * from Customers", conn);

        //     // 4. Use the connection
        //     // get query results
        //     rdr = cmd.ExecuteReader();

        //     // print the CustomerID of each record
        //     while (rdr.Read())
        //     {
        //         Console.WriteLine(rdr[1]);
        //     }
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine("Error: " + ex.Message);
        // }
        // finally
        // {
        //     // close the reader
        //     if (rdr != null)
        //     {
        //         rdr.Close();
        //     }
        //     // 5. Close the connection
        //     if (conn != null)
        //     {
        //         conn.Close();
        //     }
        // }