using System;

    class SmartDevice
    {
        public string DeviceName;
        public bool PowerStatus;

        public void TogglePower()
        {
            PowerStatus = !PowerStatus;
            Console.WriteLine($"{DeviceName} power is now {(PowerStatus ? "ON" : "OFF")}");
        }
    }

    class SmartLight : SmartDevice
    {
        public int Brightness;

        public void SetBrightness(int level)
        {
            Brightness = level;
            Console.WriteLine($"{DeviceName} brightness set to {Brightness}%");
        }
    }

    class SmartThermostat : SmartDevice
    {
        public double Temperature;

        public void SetTemperature(double temp)
        {
            Temperature = temp;
            Console.WriteLine($"{DeviceName} temperature set to {Temperature}°C");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            SmartLight light = new SmartLight { DeviceName = "Living Room Light" };
            light.TogglePower();
            light.SetBrightness(75);

            SmartThermostat thermostat = new SmartThermostat { DeviceName = "Hall Thermostat" };
            thermostat.TogglePower();
            thermostat.SetTemperature(22.5);
        }
    }

