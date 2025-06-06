using System;

public class LongestCommonSubsequence
{
    public static void LCS(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        int index = dp[m, n];
        char[] lcs = new char[index];
        int k = m, l = n;

        while (k > 0 && l > 0)
        {
            if (str1[k - 1] == str2[l - 1])
            {
                lcs[index - 1] = str1[k - 1];
                k--;
                l--;
                index--;
            }
            else if (dp[k - 1, l] > dp[k, l - 1])
            {
                k--;
            }
            else
            {
                l--;
            }
        }

        Console.WriteLine("LCS: " + new string(lcs));
        Console.WriteLine("Length: " + dp[m, n]);
    }

    public static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";
        LCS(str1, str2);
    }
}