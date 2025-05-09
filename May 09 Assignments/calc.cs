using System;

namespace ConsoleApp1
{
    class Calculator
    {
        // Addition Overloading
        
        // Add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        // Add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }
        
        // Add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}