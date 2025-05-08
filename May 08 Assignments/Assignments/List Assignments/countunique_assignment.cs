using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 5, 2, 8, 3, 9, 2, 1, 8 };
        
        // Find unique numbers using HashSet
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
        
        Console.WriteLine("Unique numbers:");
        foreach (int num in uniqueNumbers)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine($"\nTotal unique numbers: {uniqueNumbers.Count}");
    }
}