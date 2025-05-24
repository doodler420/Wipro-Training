using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> DelayedTask(string name, int delay)
    {
        await Task.Delay(delay);
        return name;
    }

    static async Task Main()
    {
        var t1 = DelayedTask("Task1", 3000);
        var t2 = DelayedTask("Task2", 1000);
        var t3 = DelayedTask("Task3", 2000);

        var winner = await Task.WhenAny(t1, t2, t3);
        Console.WriteLine($"{winner.Result} finished first");
    }
}
