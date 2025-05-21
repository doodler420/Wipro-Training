using System;
using System.Diagnostics;

public class SortingAlgorithms
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx])
                {
                    minIdx = j;
                }
            }
            int temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
    }

    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    public static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[20];
        for (int i = 0; i < 20; i++)
        {
            arr[i] = rand.Next(1, 101);
        }

        int[] arr1 = (int[])arr.Clone();
        int[] arr2 = (int[])arr.Clone();
        int[] arr3 = (int[])arr.Clone();

        Stopwatch sw = new Stopwatch();

        sw.Start();
        BubbleSort(arr1);
        sw.Stop();
        Console.WriteLine("Bubble Sort: ");
        for (int i = 0; i < arr1.Length; i++) => Console.Write(arr1[i] + " ");
        Console.WriteLine("Time taken: " + sw.ElapsedTicks + " ticks");

        sw.Restart();
        SelectionSort(arr2);
        sw.Stop();
        Console.WriteLine("Selection Sort: ");
         for (int i = 0; i < arr2.Length; i++) => Console.Write(arr2[i] + " ");
        Console.WriteLine("Time taken: " + sw.ElapsedTicks + " ticks");

        sw.Restart();
        InsertionSort(arr3);
        sw.Stop();
        Console.WriteLine("Insertion Sort: ");
         for (int i = 0; i < arr3.Length; i++) => Console.Write(arr3[i] + " ");
        Console.WriteLine("Time taken: " + sw.ElapsedTicks + " ticks");
    }
}