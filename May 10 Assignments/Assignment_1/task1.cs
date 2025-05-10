using System;

class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Appliance is operating.");
    }
}

class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing clothes");
    }
}
class Program
{
    static void Main()
    {
        // Task 1
        Appliance appliance = new Appliance();
        appliance.Operate();

        Appliance wm = new WashingMachine();
        wm.Operate();
    }
}