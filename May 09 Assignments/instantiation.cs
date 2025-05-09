using System;
//using ConsoleApp2; You can use this instead of writing under namespace ConsoleApp1{} => Method 1 of Instantiation

namespace ConsoleApp1 //Method 2 of instantiation
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student { RollNumber = 101, Name = "Neha", Marks = 90 };
            Student student2 = new Student { RollNumber = 102, Name = "Ravi", Marks = 75 };
            //if neither method1 or method2 is used,
            //  use this , given class filename is Student =>  ConsoleApp2.Student student1 = new ConsoleApp2.Student
            // {declare deets here};
            student1.PrintDetails();
            student2.PrintDetails();
        }
    }
}
