using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        //employee names list
        List<string> employees = new List<string>();
        //Add 5 employees
        employees.Add("Alice");
        employees.Add("Bob");
        employees.Add("John");
        employees.Add("Carl");
        employees.Add("Max");
        //Remove employee by name
        employees.Remove("Carl");
        //Check for an employee's existence
        bool t=employees.Contains("Bob");
        Console.WriteLine($"Contains Bob:{t}");
        //print all remaining names
        foreach(string s in employees) { Console.WriteLine(s); }
    }
}