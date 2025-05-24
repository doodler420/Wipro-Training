using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> RiskyTaskAsync(string name)
    {
        await Task.Delay(500);
        if (name == "B") throw new Exception("Task B failed");
        return $"{name} completed";
    }

    static async Task Main()
    {
        var tasks = new[]
        {
            RiskyTaskAsync("A"),
            RiskyTaskAsync("B"),
            RiskyTaskAsync("C")
        };

        try
        {
            await Task.WhenAll(tasks);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            foreach (var t in tasks)
                Console.WriteLine($"Status of {t.Id}: {t.Status}");
        }
    }
}
