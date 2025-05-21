using System;

public class SearchingAlgorithms
{
    public static int LinearSearch(int[] arr, int key)
    {
        int comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
            {
                Console.WriteLine("Linear Search Comparisons: " + comparisons);
                return i;
            }
        }
        Console.WriteLine("Linear Search Comparisons: " + comparisons);
        return -1;
    }

    public static int BinarySearch(int[] arr, int key)
    {
        int left = 0, right = arr.Length - 1, comparisons = 0;
        while (left <= right)
        {
            comparisons++;
            int mid = left + (right - left) / 2;
            if (arr[mid] == key)
            {
                Console.WriteLine("Binary Search Comparisons: " + comparisons);
                return mid;
            }
            if (arr[mid] < key)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        Console.WriteLine("Binary Search Comparisons: " + comparisons);
        return -1;
    }

    public static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[50];
        for (int i = 0; i < 50; i++)
        {
            arr[i] = rand.Next(1, 201);
        }
        Array.Sort(arr);
        int key = arr[rand.Next(0, 50)];

        Console.WriteLine("Sorted Array: ");
         for (int i = 0; i < arr.Length; i++) => Console.Write(arr[i] + " ");
        Console.WriteLine("Searching for: " + key);

        int linearResult = LinearSearch(arr, key);
        Console.WriteLine("Linear Search Result: " + linearResult);

        int binaryResult = BinarySearch(arr, key);
        Console.WriteLine("Binary Search Result: " + binaryResult);
    }
}