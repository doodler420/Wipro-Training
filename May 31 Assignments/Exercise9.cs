using System;
using System.Threading.Tasks;
using System.Diagnostics;
class Program
{
    static async Task<string> FetchWeather(string city)
    {
        await Task.Delay(2000); // Simulate API call
        return $"Weather in {city}: Sunny 25°C";
    }

    static async Task Main()
    {
        var stopwatch = Stopwatch.StartNew();

        var t1 = FetchWeather("New York");
        var t2 = FetchWeather("London");
        var t3 = FetchWeather("Tokyo");

        var results = await Task.WhenAll(t1, t2, t3);

        foreach (var result in results)
            Console.WriteLine(result);

        stopwatch.Stop();
        Console.WriteLine($"\nAll data fetched in {stopwatch.ElapsedMilliseconds} ms");
    }
}
