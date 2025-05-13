using System;

// Delegate declaration 
public delegate int SomeOperation(int i, int j);

class Program
{
    static int Sum(int x, int y) => x + y;

    static void Main()
    {
        SomeOperation add = Sum;
        Console.WriteLine(add(10, 10));  // Output: 20
    }
}