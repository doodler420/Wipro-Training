using System;

class Program
{
    public static string Palindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "Empty input is not a palindrome.";

        int n = s.Length;
        for (int i = 0; i < n / 2; i++)
        {
            if (s[i] != s[n - 1 - i])
                return $"'{s}' is not a palindrome";
        }
        return $"'{s}' is a palindrome";
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter word: ");
        string input = Console.ReadLine();
        
        string result = Palindrome(input);
        Console.WriteLine(result);
    }
}