using System;

class TowerOfHanoiProblem
{
    public static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }

        TowerOfHanoi(n - 1, from, aux, to);
        Console.WriteLine($"Move disk {n} from {from} to {to}");
        TowerOfHanoi(n - 1, aux, to, from);
    }

    static void Main()
    {
        int n = 3; // Example
        TowerOfHanoi(n, 'A', 'C', 'B');
    }
}
