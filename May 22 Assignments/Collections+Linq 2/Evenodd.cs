using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("Even: ");
        numbers.Where(n => n % 2 == 0).ToList().ForEach(n => Console.Write(n + " "));

        Console.Write("\nOdd: ");
        numbers.Where(n => n % 2 != 0).ToList().ForEach(n => Console.Write(n + " "));
    }
}