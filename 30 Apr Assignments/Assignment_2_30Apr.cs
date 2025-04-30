using System;

class Program
{
    // 1. Linear Search
    static void LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                Console.WriteLine($"{target} found at index {i}");
                return;
            }
        }
        Console.WriteLine("Not found");
    }

    // 2. Count Frequency
    static void CountFrequency(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            bool alreadyCounted = false;
            for (int j = 0; j < i; j++) 
            {
                if (arr[i] == arr[j]){
                    alreadyCounted = true;
                    break;
                }
            }
            if (!alreadyCounted){
                int count = 0;
                for (int j = 0; j < arr.Length; j++) 
                    if (arr[i] == arr[j])
                    count++;
                Console.WriteLine($"{arr[i]} occurs {count} time(s)");
            }
        }
    }

    // 3. Remove Duplicates
    static void RemoveDuplicates(int[] arr)
{
    Console.Write("Array without duplicates: ");
    for (int i = 0; i < arr.Length; i++)
    {
        bool isDuplicate = false;
        for (int j = 0; j < i; j++)
            if (arr[i] == arr[j]){
                isDuplicate = true; 
                break; 
            }
        if (!isDuplicate)
            Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

    static void Main()
    {
        int[] array = {1,2,1,3,2};
        Console.WriteLine("Linear Search:");
        LinearSearch(array, 3); 
        Console.WriteLine("Frequency Count:");
        CountFrequency(array);
        Console.WriteLine("Uniques:");
        RemoveDuplicates(array);
    }
}
