// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
        static int Ad(int a , int b){
            return a+b;
}
static int Mul(int a , int b){
            return a*b;
}
static int Sub(int a , int b){
            return a-b;
}
static int Div(int a , int b){
            return a/b;
}
    //public 
    static void Main()
    //string[] args not required, only used for cmd lines
    {
        int num=10;
        string s= "str";
        double fees=5500.75;
        bool h=true;
        int num1=20;
        int num2=10;
        //variant 1
         Console.WriteLine("num"+num);
        Console.WriteLine("s:"+s);
        Console.WriteLine("Fees:"+fees);
        Console.WriteLine("h:"+h);
        //variant 2
        Console.WriteLine($"num:{num}");
        Console.WriteLine($"s:{s}");
        Console.WriteLine($"Fees:{fees}");
        Console.WriteLine($"h:{h}");
        //dynamic code
        //inefficient == int Result=Add(num1,num2);
         Console.WriteLine("Add="+Ad(num1,num2));
         Console.WriteLine("Sub="+Sub(num1,num2));
         Console.WriteLine("Mul="+Mul(num1,num2));
         Console.WriteLine("Div="+Div(num1,num2));
    }
}