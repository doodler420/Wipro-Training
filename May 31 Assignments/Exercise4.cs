using System;
using System.IO;
using System.Threading;

class FileProcessor
{
    static int totalLines = 0;
    static object lockObj = new object();

    static void CountLines(string filePath)
    {
        int lines = File.ReadAllLines(filePath).Length;
        Console.WriteLine($"{Path.GetFileName(filePath)} has {lines} lines.");

        lock (lockObj)
        {
            totalLines += lines;
        }
    }

    static void Main()
    {
        string[] files = { "file1.txt", "file2.txt", "file3.txt" };

        Thread[] threads = new Thread[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            string path = files[i];
            threads[i] = new Thread(() => CountLines(path));
            threads[i].Start();
        }

        foreach (var t in threads)
            t.Join();

        Console.WriteLine($"\nTotal lines across all files: {totalLines}");
    }
}
