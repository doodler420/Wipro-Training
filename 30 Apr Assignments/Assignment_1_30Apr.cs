using System;

class Program
{
    static void Main()
    {
        // Exercise 1: Given a month number (1–12), print its name 
        int month = 5;  // Example input
        Console.Write("Month name = ");
        switch (month)
        {
            case 1:  Console.WriteLine("January"); break;
            case 2:  Console.WriteLine("February"); break;
            case 3:  Console.WriteLine("March"); break;
            case 4:  Console.WriteLine("April"); break;
            case 5:  Console.WriteLine("May"); break;
            case 6:  Console.WriteLine("June"); break;
            case 7:  Console.WriteLine("July"); break;
            case 8:  Console.WriteLine("August"); break;
            case 9:  Console.WriteLine("September"); break;
            case 10: Console.WriteLine("October"); break;
            case 11: Console.WriteLine("November"); break;
            case 12: Console.WriteLine("December"); break;
            default: Console.WriteLine("Invalid month number"); break;
        }

        // Exercise 2: Find the sum of digits of a number
        int number = 1234;
        int sum = 0, temp = number;
        while (temp != 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        Console.WriteLine($"Sum of digits of {number} = {sum}");

        // Exercise 3: Reverse a number
        int rev = 4567;
        int reversed = 0, copy = rev;
        while (copy != 0)
        {
            int digit = copy % 10;
            reversed = reversed * 10 + digit;
            copy /= 10;
        }
        Console.WriteLine($"Reverse of {rev} = {reversed}");

        // Exercise 4: Print squares of numbers until the square exceeds 100
        Console.WriteLine("Squares until square > 100:");
        int i = 1;
        int square;
        do
        {
            square = i * i;
            Console.WriteLine(square);
            i++;
        }
        while (square <= 100);
    }
}
