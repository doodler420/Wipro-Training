interface ICalculator
{
    void Add(int a, int b);
    void Subtract(int a, int b);
    void Multiply(int a, int b);
    void Divide(int a, int b);
}

// Implement the interface in SimpleCalculator
class SimpleCalculator : ICalculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"Multiplication: {a} × {b} = {a * b}");
    }

    public void Divide(int a, int b)
    {
            Console.WriteLine($"Division: {a} ÷ {b} = {a / b}");
    }
}

class Program
{
    static void Main()
    {
        ICalculator calculator = new SimpleCalculator();
        calculator.Add(10, 5);
        calculator.Subtract(10, 5);
        calculator.Multiply(10, 5);
        calculator.Divide(10, 5);
    }
}