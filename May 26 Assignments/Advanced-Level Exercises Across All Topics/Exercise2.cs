using System;
using System.Collections.Generic;
using System.Linq;

// Student class
public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public char Grade { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Create list of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Marks = 85, Grade = 'A' },
            new Student { Name = "Bob", Marks = 78, Grade = 'B' },
            new Student { Name = "Charlie", Marks = 92, Grade = 'A' },
            new Student { Name = "David", Marks = 70, Grade = 'C' },
            new Student { Name = "Eva", Marks = 88, Grade = 'A' },
            new Student { Name = "Frank", Marks = 65, Grade = 'D' },
            new Student { Name = "Grace", Marks = 80, Grade = 'B' },
            new Student { Name = "Helen", Marks = 75, Grade = 'B' },
            new Student { Name = "Ian", Marks = 60, Grade = 'D' },
            new Student { Name = "Jane", Marks = 95, Grade = 'A' }
        };
        // 1. Sort by marks descending
        var sortedStudents = students.OrderByDescending(s => s.Marks);
        Console.WriteLine("Students sorted by marks (descending):");
        foreach (var s in sortedStudents)
            Console.WriteLine($"{s.Name} - Marks: {s.Marks}, Grade: {s.Grade}\n");
        // 2. Group by grade
        var groupedByGrade = students.GroupBy(s => s.Grade);
        Console.WriteLine("Students grouped by grade:");
        foreach (var group in groupedByGrade)
        {
            Console.WriteLine($"Grade {group.Key}:");
            foreach (var s in group)
                Console.WriteLine($"  {s.Name} - Marks: {s.Marks}\n");
        }
        // 3. Top 3 students
        var top3 = sortedStudents.Take(3);
        Console.WriteLine("Top 3 students:");
        foreach (var s in top3)
            Console.WriteLine($"{s.Name} - Marks: {s.Marks}, Grade: {s.Grade}");
    }
}
