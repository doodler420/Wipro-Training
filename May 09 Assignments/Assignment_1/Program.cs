using System;
//using ConsoleApp1;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main()
        {
            Employee emp1 = new Employee { EmpID = 101, Salary = 12000, Name = "Bob", Department = "IT" };
            //calling the functions or methods
            emp1.PrintDetails();
            emp1.updateSalary(14000);
            Console.WriteLine("Updated Values\n");
            emp1.PrintDetails();
            int annual = emp1.annualSalary();
            Console.WriteLine($"Annual Salary:{annual}");
        }
    }
}
