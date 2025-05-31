using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public Dictionary<string, int> Marks { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", Marks = new Dictionary<string, int>{{"Math", 85}, {"Science", 90}} },
            new Student { Name = "Bob", Marks = new Dictionary<string, int>{{"Math", 70}, {"Science", 65}} },
            new Student { Name = "Carol", Marks = new Dictionary<string, int>{{"Math", 95}, {"Science", 80}} },
            new Student { Name = "David", Marks = new Dictionary<string, int>{{"Math", 88}, {"Science", 78}} }
        };

        foreach (var s in students)
        {
            var avg = s.Marks.Values.Average();
            var max = s.Marks.Values.Max();
            var min = s.Marks.Values.Min();
            Console.WriteLine($"{s.Name}: Avg = {avg}, High = {max}, Low = {min}");
        }

        var top3 = students.OrderByDescending(s => s.Marks.Values.Average()).Take(3);
        Console.WriteLine("\nTop 3 Scorers:");
        foreach (var s in top3)
            Console.WriteLine($"{s.Name} - Avg: {s.Marks.Values.Average()}");
    }
}
