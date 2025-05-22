using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1,2,3,2,4,5,3,6,7,1 };

        var dupes = numbers.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Duplicates: " + string.Join(", ", dupes));
    }
}
