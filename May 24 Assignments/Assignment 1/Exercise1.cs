using System;
using System.Threading;

class Program
{
    static bool pause = false, stop = false;
    static Thread worker;

    static void PrintNumbers()
    {
        int i = 1;
        while (i <= 100 && !stop)
        {
            if (!pause)
            {
                Console.WriteLine(i++);
                Thread.Sleep(100);
            }
        }
        Console.WriteLine("Thread finished.");
    }

    static void Main()
    {
        worker = new Thread(PrintNumbers);
        worker.Start();
        Thread.Sleep(1000);

        pause = true;
        Console.WriteLine($"ThreadState (Paused): {worker.ThreadState}");
        Thread.Sleep(2000);

        pause = false;
        Console.WriteLine($"ThreadState (Resumed): {worker.ThreadState}");
        Thread.Sleep(1000);

        stop = true;
        worker.Join();
        Console.WriteLine($"ThreadState (Stopped): {worker.ThreadState}");
    }
}
