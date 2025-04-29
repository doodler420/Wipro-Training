using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int largest;

        if (num1 >= num2 && num1 >= num3)
        {
            largest = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }

        Console.WriteLine($"The largest number is: {largest}");
    }
}
🔹 2. Print the day of the week for a number from 1 to 7
csharp
Copy
Edit
using System;

class Program
{
    static void Main()
    {
        //greatest of 3
         Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int largest;

        if (num1 >= num2 && num1 >= num3)
        {
            largest = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }

        Console.WriteLine($"The largest number is: {largest}");

//day of the week
        Console.Write("Enter a number (1 to 7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
                break;
        }
    }
}