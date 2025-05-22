using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Employee { public string Name; public string Department; }

    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "Alice", Department = "HR" },
            new Employee { Name = "Bob", Department = "IT" },
            new Employee { Name = "Charlie", Department = "IT" },
            new Employee { Name = "David", Department = "HR" },
            new Employee { Name = "Eve", Department = "Sales" },
            new Employee { Name = "Frank", Department = "Sales" }
        };

        var grouped = employees.GroupBy(e => e.Department);
        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key);
            foreach (var emp in group)
                Console.WriteLine(" " + emp.Name);
        }
    }
}
