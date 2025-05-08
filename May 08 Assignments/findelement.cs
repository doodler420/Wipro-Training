using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        List<int> numbers = new List<int>{20,40,60,80,100};
        int index=numbers.IndexOf(60);
        bool f=numbers.Contains(40);
        Console.WriteLine($"Index of 60:{index} and Contains 40:{f}");
    }
}