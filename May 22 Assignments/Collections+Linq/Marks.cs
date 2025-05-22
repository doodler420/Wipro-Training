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
            new Student { Name = "B", Marks = 90 },
            new Student { Name = "C", Marks = 85 },
            new Student { Name = "D", Marks = 60 },
            new Student { Name = "E", Marks = 95 },
            new Student { Name = "F", Marks = 75 }
        };

        var top3 = students.OrderByDescending(s => s.Marks).Take(3);
        foreach (var s in top3)
            Console.WriteLine(s.Name + ": " + s.Marks);
    }
}
