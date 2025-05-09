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
        }
    }