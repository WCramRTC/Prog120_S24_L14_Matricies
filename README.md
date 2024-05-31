# Prog120_S24_L14_Matricies

Certainly! Bubble sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The pass through the list is repeated until the list is sorted. Here's a simple implementation of bubble sort in C#:

```csharp
using System;

class BubbleSortExample
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j+1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
```

This code defines a `BubbleSortExample` class with a `Main` method that demonstrates the usage of bubble sort. The `BubbleSort` method performs the sorting, and the `PrintArray` method is used to print the elements of the array.