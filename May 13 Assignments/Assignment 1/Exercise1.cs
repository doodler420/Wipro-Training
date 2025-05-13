using System;
interface ITransport
{
    void Start();
    void Stop();
}
class Bus : ITransport
{
    public void Start() => Console.WriteLine("Bus is starting");
    public void Stop() => Console.WriteLine("Bus is stopping");
}
class Train : ITransport
{
    public void Start()=>Console.WriteLine("Train is starting");
    public void Stop()=> Console.WriteLine("Train is stopping");
}
class Program{
    static void Main()
    {
        ITransport bus = new Bus();
        ITransport train = new Train();

        bus.Start();
        bus.Stop();

        train.Start();
        train.Stop();
    }
}