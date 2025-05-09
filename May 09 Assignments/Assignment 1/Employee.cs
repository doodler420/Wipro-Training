using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        //Fields
        public int EmpID;
        public int Salary;
        public string Name;
        public string Department;
        //Print Details
        public void PrintDetails()
        {
            Console.WriteLine($"Emp ID:{EmpID}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Department:{Department}");
            Console.WriteLine($"Salary:{Salary}");
        }
        //update salary
        public void updateSalary(int newSalary)
        {
            Salary = newSalary;
        }
        //calculate annual salary
        public int annualSalary()
        {
            return Salary * 12;

        }
    }
}