using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var tasks = new[]
        {
            Task.Run(() => { Console.WriteLine("Task 1 OK"); }),
            Task.Run(() => { throw new Exception("Error in Task 2"); }),
            Task.Run(() => { Console.WriteLine("Task 3 OK"); }),
            Task.Run(() => { throw new Exception("Error in Task 4"); }),
            Task.Run(() => { Console.WriteLine("Task 5 OK"); })
        };

        try
        {
            Task.WhenAll(tasks).Wait();
        }
        catch (AggregateException aggEx)
        {
            Console.WriteLine("\nCaught errors:");
            foreach (var ex in aggEx.InnerExceptions)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        Console.WriteLine("\nAll tasks attempted.");
    }
}
