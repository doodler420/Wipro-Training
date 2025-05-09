using System;

// Base class
class Vehicle
{
    public string Make;
    public string Model;

    // Method to display vehicle details
    public void DisplayVehicle()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
    }
}

// Derived class
class Car : Vehicle
{
    public string FuelType;

    // Method to display car-specific details
    public void DisplayCar()
    {
        DisplayVehicle(); // First show the base vehicle details
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}

class Program
{
    static void Main()
    {
        // Create a Car object and set values
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.FuelType = "Hybrid";

        // Call method to print all details
        Console.WriteLine("Vehicle Details:");
        myCar.DisplayCar();
    }
}