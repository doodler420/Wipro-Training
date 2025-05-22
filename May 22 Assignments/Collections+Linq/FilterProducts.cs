using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Product { public string Name; public decimal Price; }

    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000 },
            new Product { Name = "Mouse", Price = 200 },
            new Product { Name = "Keyboard", Price = 300 },
            new Product { Name = "Monitor", Price = 600 },
            new Product { Name = "Chair", Price = 700 }
        };

        var result = products.Where(p => p.Price > 500);
        foreach (var p in result)
            Console.WriteLine(p.Name + ": " + p.Price);
    }
}
