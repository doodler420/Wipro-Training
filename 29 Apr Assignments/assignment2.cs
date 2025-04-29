// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Program
{
    static void Main()
    {
        //multiples
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"First 10 multiples of {number}:");
        for (int i = 1; i <= 10; i++){
            Console.WriteLine($"{number * i}");
        }
    }
}