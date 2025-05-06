class Program
{
    static int Sum(int num)
    {
        int s = 0;
        while (num > 0)
        {
            s = num % 10;
            num /= 10;
        }
        return s;
    }
    static void Triangle(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', i));  
        }
    }
    static int SecLargest(int[] arr)
    {
        int max = arr[0];
        int sec = arr[1];
        foreach (int i in arr)
        {
            if(i > max)
            { 
                sec = max;
                max = i;          
            }
            else if(i < sec && i != max)
            {
                sec = i;
            }
        }return sec;
    }
    static int CountWords(string sen)
    {
        string[] words = sen.Split();
        int count = 0;
        foreach (string word in words)
        {
            if (word != "")
            {
                count++;
            }
        }return count;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = 4, b = 4567;
        int[] aa = { 1, 2, 3, 4, 5 };
        string str = "this is a sentence";
        Triangle(a);
        Console.WriteLine("Sum of letters of "+b+" is "+Sum(b));   
        Console.WriteLine("Count of words for "+str+" is "+CountWords(str));    
        Console.WriteLine("Second largest element of array aa is "+SecLargest(aa)); 
    }
}