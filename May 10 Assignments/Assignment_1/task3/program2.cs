using System;

namespace ConsoleApp2{
class Program2{
static void Main{
       
        // Task 3
        AreaCalculator ac = new AreaCalculator();
        Console.WriteLine("Area of rectangle (5, 4): " + ac.Area(5.0, 4.0));
        Console.WriteLine("Area of circle (radius 3): " + ac.Area(3.0));
        Console.WriteLine("Area of triangle (base 6, height 4): " + ac.Area(6, 4)); 
        }
    }
}