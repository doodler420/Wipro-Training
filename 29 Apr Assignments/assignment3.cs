using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Multiples of 5 from 1 to 10:");

        for (int i = 1; i <= 10; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}