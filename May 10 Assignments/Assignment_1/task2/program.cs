using System;

namespace ConsoleApp2{
class Program{
static void Main{
       // Task 2
        PowerCalculator pc = new PowerCalculator();
        Console.WriteLine("2^3 = " + pc.Power(2, 3));
        Console.WriteLine("5.5^2 = " + pc.Power(5.5, 2));   
        }
    }
}