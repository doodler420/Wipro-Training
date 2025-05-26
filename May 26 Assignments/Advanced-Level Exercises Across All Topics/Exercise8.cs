using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        var images = new List<string>();
        for (int i = 1; i <= 20; i++)
            images.Add($"Image_{i}");

        int processed = 0;
        object locker = new object();

        await Parallel.ForEachAsync(images, async (img, ct) =>
        {
            await Task.Delay(200);

            int percent;
            lock (locker)
            {
                processed++;
                percent = processed * 100 / images.Count;
            }

            Console.WriteLine($"{img} processed - {percent}% done");
        });
    }
}
