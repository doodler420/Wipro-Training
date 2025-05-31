using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string input = Console.ReadLine();
        var words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var wordFreq = words.GroupBy(w => w.ToLower())
                            .ToDictionary(g => g.Key, g => g.Count());

        int vowels = input.Count(c => "aeiouAEIOU".Contains(c));
        int consonants = input.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));

        string longest = words.OrderByDescending(w => w.Length).FirstOrDefault();
        string shortest = words.OrderBy(w => w.Length).FirstOrDefault();

        Console.WriteLine("\nWord Frequency:");
        foreach (var kv in wordFreq)
            Console.WriteLine($"{kv.Key}: {kv.Value}");

        Console.WriteLine($"\nVowels: {vowels}, Consonants: {consonants}");
        Console.WriteLine($"Longest word: {longest}");
        Console.WriteLine($"Shortest word: {shortest}");
    }
}
