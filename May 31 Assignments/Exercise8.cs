using System;
using System.Collections.Generic;

interface IPrintable
{
    void Print();
}

abstract class Invoice
{
    public List<(string Item, int Qty, double Price)> Products = new();

    public void AddProduct(string item, int qty, double price) =>
        Products.Add((item, qty, price));

    public abstract double CalculateTotal();
}

class RetailInvoice : Invoice, IPrintable
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var p in Products)
            subtotal += p.Qty * p.Price;

        double tax = subtotal * 0.1;
        return subtotal + tax;
    }

    public void Print()
    {
        Console.WriteLine("Retail Invoice:");
        foreach (var p in Products)
            Console.WriteLine($"{p.Item} x{p.Qty} @ ₹{p.Price}");

        Console.WriteLine($"Total (with 10% tax): ₹{CalculateTotal()}");
    }
}

class WholesaleInvoice : Invoice, IPrintable
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var p in Products)
            subtotal += p.Qty * p.Price;

        double discount = subtotal * 0.15;
        return subtotal - discount;
    }

    public void Print()
    {
        Console.WriteLine("Wholesale Invoice:");
        foreach (var p in Products)
            Console.WriteLine($"{p.Item} x{p.Qty} @ ₹{p.Price}");

        Console.WriteLine($"Total (after 15% discount): ₹{CalculateTotal()}");
    }
}

class Program
{
    static void Main()
    {
        var retail = new RetailInvoice();
        retail.AddProduct("Pen", 5, 10);
        retail.AddProduct("Notebook", 2, 50);
        retail.Print();

        Console.WriteLine();

        var wholesale = new WholesaleInvoice();
        wholesale.AddProduct("Box", 10, 20);
        wholesale.AddProduct("Crate", 5, 100);
        wholesale.Print();
    }
}
