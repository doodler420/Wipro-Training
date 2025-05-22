using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var salaries = new Dictionary<int, decimal>
        {
            { 101, 50000 },
            { 102, 60000 },
            { 103, 55000 },
            { 104, 70000 }
        };

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());
        
       if (salaries.ContainsKey(id))
            Console.WriteLine("Salary: " + salaries[id]);
        else
            Console.WriteLine("Not found.");
    }
}
