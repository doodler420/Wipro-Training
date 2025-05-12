// Abstract Class
abstract Class Vehicle
{
    public string Brand;
    public int Year;    

    // Concrete method
    public void DisplayInfo()
    {
    Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }

    // Abstract method
    public abstract void Start();
}

// Derived Class: Car
class Car : Vehicle
{
    public override void Start()
    {
    Console.WriteLine("Car is starting with the key.");
    }
}

// Derived Class: Bike
class Bike : Vehicle
{
    public override void Start()
    {
    Console.WriteLine("Bike is starting with the kick.");
    }
}
