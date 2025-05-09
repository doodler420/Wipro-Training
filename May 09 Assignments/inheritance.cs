class Animal
{
    public string Name;
    public string Species;

    // Method to display animal details
    public void DisplayAnimal()
    {
        Console.WriteLine($"Animal Name: {Name}");
        Console.WriteLine($"Species: {Species}");
    }
}

// Derived class inheriting from Animal
class Dog : Animal
{
    public string Breed;

    // Method to display dog details
    public void DisplayDog()
    {
        Console.WriteLine($"Breed: {Breed}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of Dog class
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Species = "Canine";
        myDog.Breed = "Labrador";
        
        // Display animal details
        myDog.DisplayAnimal();
        
        // Display dog-specific details
        myDog.DisplayDog();
    }
}