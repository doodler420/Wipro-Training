using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task DoWorkAsync(CancellationToken token)
    {
        int i = 0;
        while (!token.IsCancellationRequested)
        {
            Console.WriteLine($"Working {++i}...");
            await Task.Delay(500);
        }
        Console.WriteLine("Task was cancelled.");
    }

    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var task = DoWorkAsync(cts.Token);

        await Task.Delay(2000);
        cts.Cancel();

        await task;
    }
}
