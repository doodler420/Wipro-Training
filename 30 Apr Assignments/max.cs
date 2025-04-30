using System;

public class HelloWorld
{
class Program
{
    static int FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }
    
    static void Main()
    {
        int[] scores = { 17, 42, 99, 5, 128, 63, 0, 3 };
        Console.WriteLine("Max score: " + FindMax(scores));
    }
}
}