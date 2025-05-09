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
         // Subtraction Overloading
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        
        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }

        // Multiplication Overloading
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}