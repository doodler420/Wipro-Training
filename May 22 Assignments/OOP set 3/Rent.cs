using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public decimal RatePerDay { get; set; }

    public virtual decimal CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}

class Car : Vehicle
{
    public override decimal CalculateRent(int days)
    {
        return RatePerDay * days + 500;
    }
}

class Bike : Vehicle
{
    public override decimal CalculateRent(int days)
    {
        return RatePerDay * days + 200;
    }
}

class Truck : Vehicle
{
    public override decimal CalculateRent(int days)
    {
        return RatePerDay * days + 1000;
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { VehicleNumber = "C123", Brand = "Toyota", RatePerDay = 1500 },
            new Bike { VehicleNumber = "B456", Brand = "Yamaha", RatePerDay = 500 },
            new Truck { VehicleNumber = "T789", Brand = "Volvo", RatePerDay = 2500 }
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"{vehicle.Brand} Rent for 3 days: {vehicle.CalculateRent(3)}");
        }
    }
}
