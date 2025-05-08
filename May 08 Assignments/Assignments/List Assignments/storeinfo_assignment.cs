using System;
using System.Collections.Generic;

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Laptop", Price = 100 },
            new Product { ID = 2, Name = "Mouse", Price = 200 },
            new Product { ID = 3, Name = "Keyboard", Price = 800 },
            new Product { ID = 4, Name = "Monitor", Price = 400 },
            new Product { ID = 5, Name = "Headphones", Price = 300 }
        };   
        // Sort by price (descending)
        products.Sort((a, b) => b.Price.CompareTo(a.Price));
        Console.WriteLine($"Highest price: {products[0].Name} (${products[0].Price})");
    }
}