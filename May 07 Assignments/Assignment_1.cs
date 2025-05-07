using System;
using System.Collections.Generic;
class Program{

static void CountFrequency(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            bool alreadyCounted = false;
            for (int j = 0; j < i; j++) 
            {
                if (arr[i] == arr[j]){
                    alreadyCounted = true;
                    break;
                }
            }
            if (!alreadyCounted){
                int count = 0;
                for (int j = 0; j < arr.Length; j++) 
                    if (arr[i] == arr[j])
                    count++;
                Console.WriteLine($"{arr[i]} occurs {count} time(s)");
            }
        }
    }
    static void FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        Console.WriteLine("The longest word is: " + longest);
    }
    static void FindDuplicateWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            Console.WriteLine("Duplicate words:");
            foreach (var entry in wordCount)
            {
                if (entry.Value > 1)
                    Console.WriteLine(entry.Key);
            }
        }
    static void Main()
    {
        int[] array = {1,2,1,3,2};
        string str="Hello world Longest world";
        Console.WriteLine("Frequency Count:");
        CountFrequency(array);
        FindDuplicateWords(str);
        FindLongestWord(str);
    }
}