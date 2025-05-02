using System;

class Program
{
    static int CountZeros(int n)
    {
        if (n == 0) return 1;
        if (n < 10) return 0;
        return (n % 10 == 0 ? 1 : 0) + CountZeros(n / 10);
    }

    static void Main()
    {
        int number = 2004350510;
        Console.WriteLine($"Number of zeros in {number}: {CountZeros(number)}");
    }
}