using System;

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static float Add(float a, float b) => a + b;
    public static double Add(double a, double b) => a + b;

    public static int Subtract(int a, int b) => a - b;
    public static float Subtract(float a, float b) => a - b;
    public static double Subtract(double a, double b) => a - b;

    public static int Multiply(int a, int b) => a * b;
    public static float Multiply(float a, float b) => a * b;
    public static double Multiply(double a, double b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose operation: 1.Add  2.Subtract  3.Multiply");
        int op = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();

        // Try to infer data type
        if (int.TryParse(input1, out int a) && int.TryParse(input2, out int b))
        {
            PerformOperation(op, a, b);
        }
        else if (float.TryParse(input1, out float fa) && float.TryParse(input2, out float fb))
        {
            PerformOperation(op, fa, fb);
        }
        else if (double.TryParse(input1, out double da) && double.TryParse(input2, out double db))
        {
            PerformOperation(op, da, db);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static void PerformOperation(int op, int a, int b)
    {
        switch (op)
        {
            case 1: Console.WriteLine("Result: " + Calculator.Add(a, b)); break;
            case 2: Console.WriteLine("Result: " + Calculator.Subtract(a, b)); break;
            case 3: Console.WriteLine("Result: " + Calculator.Multiply(a, b)); break;
        }
    }

    static void PerformOperation(int op, float a, float b)
    {
        switch (op)
        {
            case 1: Console.WriteLine("Result: " + Calculator.Add(a, b)); break;
            case 2: Console.WriteLine("Result: " + Calculator.Subtract(a, b)); break;
            case 3: Console.WriteLine("Result: " + Calculator.Multiply(a, b)); break;
        }
    }

    static void PerformOperation(int op, double a, double b)
    {
        switch (op)
        {
            case 1: Console.WriteLine("Result: " + Calculator.Add(a, b)); break;
            case 2: Console.WriteLine("Result: " + Calculator.Subtract(a, b)); break;
            case 3: Console.WriteLine("Result: " + Calculator.Multiply(a, b)); break;
        }
    }
}
