using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public decimal GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}

class ShoppingCart
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public void AddItem(CartItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(CartItem item)
    {
        Items.Remove(item);
    }

    public decimal GetCartTotal()
    {
        decimal total = 0;
        foreach (var item in Items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product { Id = 1, Name = "Laptop", Price = 45000 };
        Product p2 = new Product { Id = 2, Name = "Mouse", Price = 700 };

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(new CartItem { Product = p1, Quantity = 1 });
        cart.AddItem(new CartItem { Product = p2, Quantity = 2 });

        Console.WriteLine($"Total Cart Value: {cart.GetCartTotal()}");
    }
}
