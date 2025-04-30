using System;

public class Program
{
    // Static method to calculate square
    static int Square(int number)
    {
        return number * number;
    }

    // Greet method
    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    // Print welcome message
    static void PrintMessage()
    {
        Console.WriteLine("Welcome");
    }

    static void Main()
    {
        // Print welcome message
        PrintMessage();

        // Calculate square
        int result = Square(5);
        Console.WriteLine("Square is: " + result);

        // Greet user
        Greet("John");
    }
}
