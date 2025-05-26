using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string text = "This is a test. This test is only a test. test test test!";
        var words = text.Split(new[] { ' ', '.', '!', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);

        var freq = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!freq.ContainsKey(word))
                freq[word] = 0;
            freq[word]++;
        }

        var top5 = freq.OrderByDescending(kv => kv.Value).Take(5);
        Console.WriteLine("Top 5 words:");
        foreach (var kv in top5)
            Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}
