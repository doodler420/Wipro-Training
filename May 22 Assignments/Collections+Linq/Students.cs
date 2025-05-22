using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var students = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

        foreach (var student in students)
            Console.WriteLine(student);

        students.Sort();
        Console.WriteLine();
        foreach (var student in students)
            Console.WriteLine(student);
    }
}
