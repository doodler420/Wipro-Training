using System;
using System.Collections.Generic;
using System.Linq;

class VowelNamesExercise
{
    static void Main()
    {
        var names = new List<string>
        {
            "Alice", "Bob", "Eve", "Oscar", "Uma", "Charlie", "Ivy", "Andy", "Victor", "Olga"
        };

        var vowels = new[] { 'A', 'E', 'I', 'O', 'U' ,'a' ,'e' ,'i', 'o' ,'u' };
        var filtered = names.Where(n => vowels.Contains(n[0]));
        foreach (var name in filtered)
            Console.WriteLine(name);
    }
}
