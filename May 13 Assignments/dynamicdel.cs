using System;

class Program
{
    static int Sum(int x, int y) => x + y;

    static void Main()
    {
        Func<int,int,int> add= Sum;
        Console.WriteLine(add(10, 10));  // Output: 20
    }
}