using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Student { public string Name; public int Marks; }

    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "A", Marks = 70 },
            new Student { Name = "B", Marks = 80 },
            new Student { Name = "C", Marks = 90 },
            new Student { Name = "D", Marks = 60 },
            new Student { Name = "E", Marks = 75 }
        };

        var avg = students.Average(s => s.Marks);
        var count = students.Count(s => s.Marks > avg);
        Console.WriteLine("Above average: " + count);
    }
}
