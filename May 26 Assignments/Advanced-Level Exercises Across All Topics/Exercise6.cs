using System;
using System.Collections.Generic;
using System.Linq;

class Item
{
    public string Name;
    public string Type;
    public int Stock;
    public double Price;
}

class Program
{
    static void Main()
    {
        var items = new List<Item>
        {
            new Item { Name = "Pen", Type = "Stationery", Stock = 5, Price = 10 },
            new Item { Name = "Pencil", Type = "Stationery", Stock = 2, Price = 5 },
            new Item { Name = "Notebook", Type = "Stationery", Stock = 12, Price = 25 },
            new Item { Name = "Shirt", Type = "Clothing", Stock = 3, Price = 500 },
            new Item { Name = "Jeans", Type = "Clothing", Stock = 8, Price = 1200 },
            new Item { Name = "Jacket", Type = "Clothing", Stock = 1, Price = 3000 },
            new Item { Name = "Apple", Type = "Fruit", Stock = 20, Price = 15 },
            new Item { Name = "Banana", Type = "Fruit", Stock = 6, Price = 7 },
            new Item { Name = "Mango", Type = "Fruit", Stock = 2, Price = 40 },
            new Item { Name = "TV", Type = "Electronics", Stock = 4, Price = 15000 },
            new Item { Name = "Laptop", Type = "Electronics", Stock = 3, Price = 50000 },
            new Item { Name = "Mouse", Type = "Electronics", Stock = 10, Price = 800 },
            new Item { Name = "Chair", Type = "Furniture", Stock = 9, Price = 2000 },
            new Item { Name = "Table", Type = "Furniture", Stock = 0, Price = 3000 },
            new Item { Name = "Sofa", Type = "Furniture", Stock = 1, Price = 15000 },
        };

        var lowStock = items.Where(i => i.Stock < 5);
        var grouped = items.GroupBy(i => i.Type);
        var highestByType = grouped.Select(g => g.OrderByDescending(i => i.Price).First());

        Console.WriteLine("Low Stock Items:");
        foreach (var i in lowStock)
            Console.WriteLine($"{i.Name} ({i.Stock})");

        Console.WriteLine("\nItems Grouped by Type:");
        foreach (var group in grouped)
        {
            Console.WriteLine($"{group.Key}:");
            foreach (var item in group)
                Console.WriteLine($"  {item.Name} - {item.Price}");
        }

        Console.WriteLine("\nHighest Priced Item in Each Type:");
        foreach (var i in highestByType)
            Console.WriteLine($"{i.Type}: {i.Name} - {i.Price}");
    }
}
