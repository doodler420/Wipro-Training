using System;
using System.Collections.Generic;

interface IRentable
{
    void Rent();
}
class Vehicle : IRentable
{
    public virtual void Rent();
}
class Car : Vehicle
{
    public override void Rent() => Console.WriteLine("Car - ₹50/day");
}
class Bike : Vehicle
{
    public override void Rent() => Console.WriteLine("Bike - ₹20/day");
}
class Truck : Vehicle
{
        public override void Rent() => Console.WriteLine("Truck - ₹100/day");
}
class Program
{    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(),
            new Bike(),
            new Truck()
        };
        foreach (var v in vehicles)
            v.Rent();
    }
}
