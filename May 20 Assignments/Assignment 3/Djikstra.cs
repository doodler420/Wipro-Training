using System;

public class DijkstraAlgorithm
{
    public static int MinDistance(int[] dist, bool[] sptSet, int vertices)
    {
        int min = int.MaxValue, minIndex = -1;
        for (int v = 0; v < vertices; v++)
        {
            if (!sptSet[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    public static void PrintSolution(int[] dist, int vertices, int src)
    {
        Console.WriteLine("Node \t Distance from Source");
        for (int i = 0; i < vertices; i++)
        {
            Console.WriteLine(i + " \t\t " + dist[i]);
        }
    }

    public static void Dijkstra(int[,] graph, int src, int vertices)
    {
        int[] dist = new int[vertices];
        bool[] sptSet = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[src] = 0;

        for (int count = 0; count < vertices - 1; count++)
        {
            int u = MinDistance(dist, sptSet, vertices);
            sptSet[u] = true;

            for (int v = 0; v < vertices; v++)
            {
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        PrintSolution(dist, vertices, src);
    }

    public static void Main()
    {
        int vertices = 5;
        int[,] graph = new int[,]
        {
            { 0, 4, 0, 0, 0 },
            { 4, 0, 8, 0, 0 },
            { 0, 8, 0, 7, 0 },
            { 0, 0, 7, 0, 9 },
            { 0, 0, 0, 9, 0 }
        };

        Dijkstra(graph, 0, vertices);
    }
}