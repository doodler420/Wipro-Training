using System;
using ConsoleApp1;
  class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            
            // Using the overloaded Add methods
            Console.WriteLine(calc.Add(5, 10));           // Output: 15
            Console.WriteLine(calc.Add(3.5, 2.7));        // Output: 6.2
            Console.WriteLine(calc.Add(1, 2, 3));         // Output: 6
            
             // Test subtraction
            Console.WriteLine("\nSubtraction:");
            Console.WriteLine(calc.Subtract(10, 4));     // 6
            Console.WriteLine(calc.Subtract(7.5, 2.3));    // 5.2
            Console.WriteLine(calc.Subtract(20, 5, 3));    // 12

            // Test multiplication
            Console.WriteLine("\nMultiplication:");
            Console.WriteLine(calc.Multiply(5, 4));       // 20
            Console.WriteLine(calc.Multiply(2.5, 3.0));   // 7.5
            Console.WriteLine(calc.Multiply(2, 3, 4));     // 24
        }
    }