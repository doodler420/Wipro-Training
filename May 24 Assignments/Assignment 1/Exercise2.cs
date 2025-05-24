class Program
{
    static void Print() => Console.WriteLine("Printing...");
    static void Compute() => Console.WriteLine("Computing...");
    static void Wait() => Thread.Sleep(500);

    static void Main()
    {
        Thread t1 = new Thread(Print);
        Thread t2 = new Thread(Compute);
        Thread t3 = new Thread(Wait);

        t1.Start(); t2.Start(); t3.Start();

        t1.Join(); t2.Join(); t3.Join();
        Console.WriteLine("All tasks done");
    }
}
