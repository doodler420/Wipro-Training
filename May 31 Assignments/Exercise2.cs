using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { ID = 2, Name = "Bob", Department = "IT", Salary = 75000 },
            new Employee { ID = 3, Name = "Charlie", Department = "HR", Salary = 52000 },
            new Employee { ID = 4, Name = "David", Department = "IT", Salary = 90000 },
            new Employee { ID = 5, Name = "Eve", Department = "Finance", Salary = 65000 },
        };

        string filterDept = "IT";
        var filtered = employees.Where(e => e.Department == filterDept);

        Console.WriteLine($"{filterDept} department:");
        foreach (var emp in filtered)
            Console.WriteLine($"{emp.Name} - ₹{emp.Salary}");

        var sorted = employees.OrderByDescending(e => e.Salary);
        
        Console.WriteLine("\nsorted by salary descending:");
        foreach (var emp in sorted)
            Console.WriteLine($"{emp.Name} ({emp.Department}) - ₹{emp.Salary}");

        var avgSalaryPerDept = employees
            .GroupBy(e => e.Department)
            .Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) });

        Console.WriteLine("\nAverage salary per department:");
        foreach (var dept in avgSalaryPerDept)
            Console.WriteLine($"{dept.Department}: ₹{dept.AverageSalary:F2}");
    }
}
