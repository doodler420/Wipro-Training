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
    // static void CountFrequencies(int[] arr)
    // {
    //     Dictionary<int, int> freq = new Dictionary<int, int>();

    //     foreach (int num in arr)
    //     {
    //         if (freq.ContainsKey(num))
    //             freq[num]++;
    //         else
    //             freq[num] = 1;
    //     }

    //     foreach (var pair in freq)
    //     {
    //         Console.WriteLine($"{pair.Key} appears {pair.Value} time(s)");
    //     }
    // } better code reference
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
    //      static void FindDuplicateWords(string sentence)
    // {
    //     string[] words = sentence.Split(' ');

    //     for (int i = 0; i < words.Length; i++)
    //     {
    //         for (int j = i + 1; j < words.Length; j++)
    //         {
    //             if (words[i] == words[j])
    //             {
    //                 Console.WriteLine(words[i]);
    //                 break;  // To avoid printing the same duplicate multiple times
    //             }
    //         }
    //     }
    // } better code reference

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