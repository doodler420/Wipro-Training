using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> GetTemperatureAsync(string city)
    {
        await Task.Delay(1000);
        Random rnd = new Random();
        return rnd.Next(15, 40);
    }

    static async Task Main()
    {
        var c1 = GetTemperatureAsync("Delhi");
        var c2 = GetTemperatureAsync("London");
        var c3 = GetTemperatureAsync("Tokyo");

        Console.WriteLine($"Delhi: {await c1}°C");
        Console.WriteLine($"London: {await c2}°C");
        Console.WriteLine($"Tokyo: {await c3}°C");
    }
}
