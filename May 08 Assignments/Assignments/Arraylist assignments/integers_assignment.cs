using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();
        //random input
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(rand.Next(1, 51));
        }
        
        // Sort and convert to List<int> for calculations
        numbers.Sort();
        List<int> sortedNumbers = numbers.Cast<int>().ToList();
        
        int max = sortedNumbers.Max();
        int min = sortedNumbers.Min();
        double avg = sortedNumbers.Average();
        
        Console.WriteLine("Sorted numbers:");
        foreach (int num in sortedNumbers)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine($"\nMax: {max}, Min: {min}, Average: {avg}");
    }
}