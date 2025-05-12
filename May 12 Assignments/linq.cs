using System;
using System.Collections.Generic;
using System.Linq;

namespace linq

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { 
                "Anil", "Sharma", "Abdullah",
                "Imran", "Siva", "Naresh",
                "Suresh", "Suman" 
            };
            
            // Using LINQ Query
            UsingLinq(names);
        }

        private static void UsingLinq(string[] names)
        {
            // LINQ query to find names starting with 'S' and order them
            var query = from name in names
                        where name.StartsWith("S")
                        orderby name
                        select name;

            Console.WriteLine("Names starting with 'S':");
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}