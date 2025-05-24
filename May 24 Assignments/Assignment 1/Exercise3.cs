using System.Threading;

class Program
{
    static void ProcessItem(object item)
    {
        Thread.Sleep(500);
        Console.WriteLine($"Processed {item}");
    }

    static void Main()
    {
        for (int i = 1; i <= 5; i++)
            ThreadPool.QueueUserWorkItem(ProcessItem, $"Item {i}");

        Thread.Sleep(2000); // Wait for all to finish
    }
}
