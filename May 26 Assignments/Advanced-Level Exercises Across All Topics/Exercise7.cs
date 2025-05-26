using System;

public abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}

public class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing {inputPath} to {outputPath} using ZIP");
    }
}

public class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing {inputPath} to {outputPath} using RAR");
    }
}

public class Compressor
{
    public CompressionStrategy Strategy;

    public Compressor(CompressionStrategy strategy)
    {
        Strategy = strategy;
    }

    public void SetStrategy(CompressionStrategy newStrategy)
    {
        Strategy = newStrategy;
    }

    public void Compress(string input, string output)
    {
        Strategy.Compress(input, output);
    }
}

public class Program
{
    public static void Main()
    {
        var zip = new ZipCompression();
        var rar = new RarCompression();

        var compressor = new Compressor(zip);
        compressor.Compress("file.txt", "file.zip");

        compressor.SetStrategy(rar);
        compressor.Compress("file.txt", "file.rar");
    }
}
