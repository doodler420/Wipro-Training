using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task<string> Server(string name, CancellationToken token)
    {
        var delay = new Random().Next(500, 2000);
        await Task.Delay(delay, token);
        return $"{name} responded in {delay}ms";
    }

    static async Task Main()
    {
        var cts = new CancellationTokenSource();

        var t1 = Server("Server1", cts.Token);
        var t2 = Server("Server2", cts.Token);
        var t3 = Server("Server3", cts.Token);

        var fastest = await Task.WhenAny(t1, t2, t3);
        Console.WriteLine(await fastest);

        cts.Cancel();
    }
}
