using System;
using System.Collections.Generic;

interface IAttendance
{
    void MarkAttendance();
}

abstract class Staff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public abstract decimal CalculateSalary();
}

class PermanentStaff : Staff, IAttendance
{
    public override decimal CalculateSalary()
    {
        return 40000;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Permanent) marked attendance.");
    }
}

class ContractStaff : Staff, IAttendance
{
    public override decimal CalculateSalary()
    {
        return 20000;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Contract) marked attendance.");
    }
}

class Program
{
    static void Main()
    {
        List<Staff> staffList = new List<Staff>
        {
            new PermanentStaff { Id = 1, Name = "Alice", Department = "HR" },
            new ContractStaff { Id = 2, Name = "Bob", Department = "IT" }
        };

        foreach (var staff in staffList)
        {
            Console.WriteLine($"{staff.Name} Salary: {staff.CalculateSalary()}");
            ((IAttendance)staff).MarkAttendance();
        }
    }
}
