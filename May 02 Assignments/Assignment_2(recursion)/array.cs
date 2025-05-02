using System;

class Program
{
    static void PrintArray(int[] arr, int i = 0)
    {
        if (i >= arr.Length) return;
        Console.WriteLine(arr[i]);
        PrintArray(arr, i + 1);
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array elements:");
        PrintArray(numbers);
    }
}