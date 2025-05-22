using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string sentence = "C# is great and C# is fun";
        var words = sentence.Split(' ');
        var count = words.GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());

        foreach (var wrd in count)
            Console.WriteLine(wrd.Key + ": " + wrd.Value);
    }
}
