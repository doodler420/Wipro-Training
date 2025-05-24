using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync(string fileName, int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"{fileName} downloaded. Delay: {delay} ms");
    }

    static async Task Main()
    {
        int[] delays = { 1000, 2000, 1500 };

        var tasks = new[]
        {
            DownloadFileAsync("File1", delays[0]),
            DownloadFileAsync("File2", delays[1]),
            DownloadFileAsync("File3", delays[2])
        };

        await Task.WhenAll(tasks);

        int totalDelay = 0;
        foreach (var delay in delays)
        {
            totalDelay += delay;
        }

        Console.WriteLine($"Total delay: {totalDelay} ms");
    }
}
