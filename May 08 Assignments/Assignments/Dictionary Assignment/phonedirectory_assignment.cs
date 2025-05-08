using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>
        {
            { "Alice", "1234567890" },
            { "Bob", "2345678901" },
            { "Charlie", "3456789012" },
            { "David", "4567890123" },   
        };
        
        //add
        phoneBook.Add("Eve","5678901234");
        // Update a phone number
        phoneBook["Bob"] = "0000000000";
        // Check if a name exists
        bool hasCharlie = phoneBook.ContainsKey("Charlie");
        Console.WriteLine($"Contains Charile: {hasCharlie}");
        // Print all contacts
        Console.WriteLine("\nContacts:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }
    }
}