using System;
abstract class Employee
{
    public void ShowBasicInfo() => Console.WriteLine("Employee details");
    public abstract void CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public override void CalculateSalary() => 
        Console.WriteLine("Salary: Basic + Allowance");
}

class PartTimeEmployee : Employee
{
    public override void CalculateSalary() => 
        Console.WriteLine("Salary: Hourly rate × Hours worked");
}

class Program
{
    static void Main()
    {
        Employee fullTime = new FullTimeEmployee();
        Employee partTime = new PartTimeEmployee();
        
        fullTime.ShowBasicInfo();
        fullTime.CalculateSalary();
        
        partTime.ShowBasicInfo();
        partTime.CalculateSalary();
    }
}