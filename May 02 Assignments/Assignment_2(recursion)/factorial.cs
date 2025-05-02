using System;

class Program
{
    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        int i=5;
        Console.WriteLine($"{i}! = {Factorial(i)}");
    }
}
