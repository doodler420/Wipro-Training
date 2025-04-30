using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Element {i + 1}: {arr[i]}");
        }
    }
    //reverse
    static void Reverse(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Element {arr.Length - i}: {arr[i]}");
        }
    }
    //square
    static void Square(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int square = arr[i] * arr[i];
            Console.WriteLine($"Square of {i + 1} = {square}");
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        PrintArray(numbers);
        Reverse(numbers);
        Square(numbers);
    }
}
