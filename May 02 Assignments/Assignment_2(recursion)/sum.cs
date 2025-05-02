using System;

class Program
{
    static int SumDigits(int n)
    {
        if (n == 0) return 0;
        return n % 10 + SumDigits(n / 10);
    }

    static void Main()
    {
        int number = 12345;
        Console.WriteLine($"Sum of digits in {number}: {SumDigits(number)}");
    }
}