using System;

class Program
{
    //another way to write methods with single line
    static int Add(int a, int b) => return a + b;
    static double Add(double a, double b)=> return a + b;
    static int Subtract(int a, int b) => return a - b;
    static double Subtract(double a, double b)=> return a - b;
    static int Multiply(int a, int b)=>return a * b;
    static double Multiply(double a, double b)=>return a * b;
    //ternary operators
    static int Divide(int a , int b) => b==0 ? 0 : (double)a/b;
    static void Main()
    {
        //method overloading or static binding
        Console.WriteLine("Int Add: " + Add(3, 4));        // 7
        Console.WriteLine("Double Add: " + Add(2.5, 4.3)); // 6.8
        Console.WriteLine("Int Subtract: " + Subtract(10, 3));      // 7
        Console.WriteLine("Double Subtract: " + Subtract(5.5, 1.2));// 4.3
        Console.WriteLine("Int Multiply: " + Multiply(3, 4));        // 12
        Console.WriteLine("Double Multiply: " + Multiply(2.5, 4.0)); // 10.0
        Console.WriteLine("Divide" + Divide(3, 4));        // 0.75
    }
}
