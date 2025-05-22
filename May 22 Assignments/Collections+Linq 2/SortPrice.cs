using System;
using System.Collections.Generic;
using System.Linq;

class SortProductsExercise
{
    class Product { public int Id; public string Name; public decimal Price; }

    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "A", Price = 300 },
            new Product { Id = 2, Name = "B", Price = 700 },
            new Product { Id = 3, Name = "C", Price = 500 },
            new Product { Id = 4, Name = "D", Price = 900 },
            new Product { Id = 5, Name = "E", Price = 100 }
        };

        var sorted = products.OrderByDescending(p => p.Price);
        foreach (var p in sorted)
            Console.WriteLine(p.Name + ": " + p.Price);
    }
}
