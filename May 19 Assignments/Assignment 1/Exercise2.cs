using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeID = 1, Name = "John", Salary = 50000 },
            new Employee { EmployeeID = 2, Name = "Alice", Salary = 60000 },
            new Employee { EmployeeID = 3, Name = "Bob", Salary = 55000 },
            new Employee { EmployeeID = 4, Name = "Eve", Salary = 70000 },
            new Employee { EmployeeID = 5, Name = "Charlie", Salary = 45000 }
        };

        var maxsal = employees.OrderByDescending(e => e.Salary).First();
        Console.WriteLine($"Highest salary: {maxsal.Name}, {maxsal.Salary}");

        var employeeDictionary = new Dictionary<int, string>();
        foreach (var emp in employees)
        {
            employeeDictionary[emp.EmployeeID] = emp.Name;
        }
        //Dictionary<int, string> employeeDictionary = employees.ToDictionary(e => e.EmployeeID, e => e.Name);
        foreach (var entry in employeeDictionary)
        {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }

        int searchId = 4;
        if (employeeDictionary.ContainsKey(searchId))
        {
            Console.WriteLine($"Employee found: {name}");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
}