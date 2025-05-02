using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {   
        int n=8;
        Console.WriteLine($"Fibonacci Sequence up to {n} :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}