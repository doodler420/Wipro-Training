using System;
using System.Collections.Generic;

class CoinChange
{
    static void Main()
    {
        int[] denominations = {500, 200, 100, 50, 20, 10, 5, 2, 1};
        int amount = 880;
        List<int> result = new List<int>();
        
        foreach (int coin in denominations)
        {
            while (amount >= coin)
            {
                amount -= coin;
                result.Add(coin);
            }
        }

        Console.WriteLine("Coins used: " + string.Join(", ", result));
        Console.WriteLine("Total coins: " + result.Count);
    }
}
