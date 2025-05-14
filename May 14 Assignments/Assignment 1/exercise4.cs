using System;

abstract class FoodOrder
{
    public void OrderInfo() => Console.WriteLine("Placing food order");
    public abstract void PlaceOrder(string item);
}

class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder(string item) => 
        Console.WriteLine($"Order placed for {item} at Fast Food Outlet");
}

class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder(string item) => 
        Console.WriteLine($"Order placed for {item} at Fine Dining Restaurant");
}

class Program
{
    static void Main()
    {
        FoodOrder fastFood = new FastFoodOrder();
        FoodOrder fineDining = new FineDiningOrder();
        
        fastFood.OrderInfo();
        fastFood.PlaceOrder("Burger Meal");
        
        fineDining.OrderInfo();
        fineDining.PlaceOrder("Steak Dinner");
    }
}