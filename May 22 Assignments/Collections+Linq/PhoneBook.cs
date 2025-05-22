using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var phoneBook = new Dictionary<string, string>
        {
            { "Alice", "1234567890" },
            { "Bob", "9876543210" },
            { "Charlie", "5556667777" }
        };

        foreach (var entry in phoneBook)
            Console.WriteLine(entry.Key + ": " + entry.Value);

        Console.Write("\nEnter a name to search: ");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine(name + "'s number is " + phoneBook[name]);
        }
        else
        {
            Console.WriteLine("Not found.");
        }
    }
}
