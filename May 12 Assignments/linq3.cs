using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
 
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
            IEnumerable<string> query = names
                                        .Where(s => s.Length == 5)
                                        .OrderBy(s => s)
                                        .Select(s => s.ToUpper());

            foreach (string item in query)
                Console.WriteLine(item);
    
            Console.Read();

        }
    }
}
