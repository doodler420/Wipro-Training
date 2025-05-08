using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList students = new ArrayList();
        
        // Add 5 names
        students.Add("Alice");
        students.Add("Bob");
        students.Add("John");
        students.Add("David");
        students.Add("Max");
        
        // Remove a specific name
        students.Remove("David");
        
        // Display remaining names
        Console.WriteLine("Students after removal:");
        foreach (string name in students)
        {
            Console.WriteLine(name);
        }
        
        // Check if a name exists
        bool hasBob = students.Contains("Bob");
        Console.WriteLine($"Contains Bob:{hasBob}");
    }
}