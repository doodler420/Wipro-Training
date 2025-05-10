using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
class AreaCalculator
{
    public double Area(double length, double breadth)
    {
        return length * breadth; // Rectangle
    }

    public double Area(double radius)
    {
        return 3.14* radius * radius; // Circle
    }

    public double Area(int baseLength, int height)
    {
        return 0.5 * baseLength * height; // Triangle
    }
}
}