using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static Queue<string> q = new Queue<string>();
    static object ob = new object();
    static bool done = false;

    static void Worker()
    {
        while (true)
        {
            string task = null;
            lock (ob)
            {
                if (q.Count > 0) task = q.Dequeue();
                else if (done) break;
            }
            if (task != null) Console.WriteLine(task);
            else Thread.Sleep(500);
        }
    }

    static void Main()
    {
        var t = new Thread(Worker);
        t.Start();

        for (int i = 1; i <= 5; i++)
        {
            lock (ob) q.Enqueue($"Task {i}");
            Thread.Sleep(500);
        }

        lock (ob) done = true;
        t.Join();
    }
}
