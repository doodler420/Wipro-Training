using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is supervising.");
    }
}

class Program
{
    static void Main()
    {
        // Base class method call
        Employee emp = new Employee();
        emp.Work();  // Output: "Employee is working."

        // Derived class method call
        Manager mgr = new Manager();
        mgr.Work();  // Output: "Manager is supervising."

        // Polymorphism in action
        Employee polyEmp = new Manager();
        polyEmp.Work();  // Output: "Manager is supervising."
    }
}