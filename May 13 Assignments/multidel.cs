using System;

// Define a custom delegate
delegate void CustomDel(string s);

class Program
{
    // Methods matching the delegate signature
    static void Hello(string s) => Console.WriteLine($"Hello, {s}!");
    static void Goodbye(string s) => Console.WriteLine($"Goodbye, {s}!");

    static void Main()
    {
        // Declare delegate instances
        CustomDel hiDel, byeDel, multiDel;

        // Assign methods to delegates
        hiDel = Hello;
        byeDel = Goodbye;

        // Combine delegates to create a multicast delegate
        multiDel = hiDel + byeDel;  
        multiminushiDel=multiDel-hiDel;

        // Invoke delegates
        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");  // Output: Hello, A!

        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("B");  // Output: Goodbye, B!

        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");  // Output: Hello, C! → Goodbye, C!

        Console.WriteLine("Invoking delegate multiminushiDel => multiDel without hiDel:");
        hiDel("D");  // Output: Hello, D!
    }
}