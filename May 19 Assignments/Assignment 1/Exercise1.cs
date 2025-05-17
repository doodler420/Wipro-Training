using System;

public abstract class SmartDevice
{
    public abstract void TurnOn();
    public void ShowStatus() => Console.WriteLine("Device status: Active");
}

public interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}

public class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn() => Console.WriteLine("Smart Light turned on");
    public void IncreaseVolume() => Console.WriteLine("Lights do not support volume control");
    public void DecreaseVolume() => Console.WriteLine("Lights do not support volume control");
}

public class SmartSpeaker : SmartDevice, IRemoteControl
{
    public override void TurnOn() => Console.WriteLine("Smart Speaker turned on");
    public void IncreaseVolume() => Console.WriteLine("Volume increased");
    public void DecreaseVolume() => Console.WriteLine("Volume decreased");
}

public class Program
{
    public static void Main()
    {
        SmartDevice light = new SmartLight();
        SmartDevice speaker = new SmartSpeaker();

        light.ShowStatus();
        light.TurnOn();
        light.IncreaseVolume();
        light.DecreaseVolume();

        speaker.ShowStatus();
        speaker.TurnOn();
        speaker.IncreaseVolume();
        speaker.DecreaseVolume();
    }
}