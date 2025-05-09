using System;
using System.Collections.Generic;

class Student{
    //Fields
    public int RollNo;
    public string Name;
    public int Marks;

    public void PrintDetails(){
        Console.WriteLine($"Roll number:{RollNo}");
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Marks:{Marks}");
    }

}
class Program{
    static void Main(){
        Student student1= new Student();

        student1.RollNo=101;
        student1.Name="Amit";
        student1.Marks=85;

        student1.PrintDetails();

    }

}