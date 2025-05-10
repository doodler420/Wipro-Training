using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
class PowerCalculator
{
    public int Power(int baseNum, int exponent)
    {
        return (int)Math.Pow(baseNum, exponent);
    }

    public double Power(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }
}
}