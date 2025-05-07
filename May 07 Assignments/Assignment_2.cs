using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create an ArrayList of student names
        ArrayList students = new ArrayList();
        // Add 5 names to the list
        students.Add("John");
        students.Add("Emily");
        students.Add("Michael");
        students.Add("Sarah");
        students.Add("David");
        // Check if a specific name exists
        string srch = "Emily";
        Console.WriteLine(students.Contains(srch) ? $"{srch} is in the list." : $"{srch} is not in the list.");
        // Remove the second name 
        students.RemoveAt(1);
        // Display the final list
        Console.WriteLine("\nFinal list of students:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}