using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine($"Feeding {Name}");
    }
}

class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars");
    }
}

class Elephant : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} trumpets");
    }
}

class Monkey : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} chatters");
    }
}

class Zoo
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public void PerformActions()
    {
        foreach (var animal in Animals)
        {
            animal.MakeSound();
            animal.Feed();
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();
        zoo.Animals = new List<Animal>
        {
            new Lion { Name = "Leo", Age = 5 },
            new Elephant { Name = "Ella", Age = 10 },
            new Monkey { Name = "Max", Age = 3 }
        };

        zoo.PerformActions();
    }
}
