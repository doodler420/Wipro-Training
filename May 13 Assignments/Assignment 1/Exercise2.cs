using System;
interface IOrder
{
    void PlaceOrder(string item);
    void CancelOrder(string item);
}

class DineInOrder : IOrder
{
    public void PlaceOrder(string item) => Console.WriteLine($"Placing dine-in order for {item}");
    public void CancelOrder(string item) => Console.WriteLine($"Canceling dine-in order for {item}");
}

class TakeawayOrder : IOrder
{
    public void PlaceOrder(string item) => Console.WriteLine($"Placing takeaway order for {item}");
    public void CancelOrder(string item) => Console.WriteLine($"Canceling takeaway order for {item}");
}

class Program
{
    static void Main()
    {
        IOrder dineIn = new DineInOrder();
        IOrder takeaway = new TakeawayOrder();
        
        dineIn.PlaceOrder("Pizza");
        dineIn.CancelOrder("Pizza");
        
        takeaway.PlaceOrder("Burger");
        takeaway.CancelOrder("Burger");
    }
}