// Define a custom delegate that takes a string parameter and returns void
delegate void CustomDel(string s);

class TestClass
{
    // Method that matches the CustomDel signature
    static void Hello(string s)
    {
        Console.WriteLine($"Hello, {s}!");
    }

    static void Main()
    {
        // Declare and initialize the delegate
        CustomDel hiDel = Hello;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");  // Output: Hello, A!
    }
}