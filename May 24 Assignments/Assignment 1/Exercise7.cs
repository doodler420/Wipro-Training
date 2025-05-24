using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task SimulateWorkAsync(string name, int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"{name} done");
    }

    static async Task Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        await SimulateWorkAsync("A", 1000);
        await SimulateWorkAsync("B", 1000);
        await SimulateWorkAsync("C", 1000);
        sw.Stop();
        Console.WriteLine($"Sequential time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        var tasks = new[]
        {
            SimulateWorkAsync("A", 1000),
            SimulateWorkAsync("B", 1000),
            SimulateWorkAsync("C", 1000)
        };
        await Task.WhenAll(tasks);
        sw.Stop();
        Console.WriteLine($"Parallel time: {sw.ElapsedMilliseconds} ms");
    }
}
