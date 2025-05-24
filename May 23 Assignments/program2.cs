using System;
using System.Threading;

class Program2
{
   static void Main()
   {
       int a = 5;
       int b = 10;
       Thread thread = new Thread(() => Console.WriteLine($"sum:{a + b}"));
       thread.Start();
   }
}