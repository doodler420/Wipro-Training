using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        list.Remove(42);
        list.RemoveAt(0);
        Console.WriteLine("Count after remove: " + list.Count); // Output: Inserted

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}