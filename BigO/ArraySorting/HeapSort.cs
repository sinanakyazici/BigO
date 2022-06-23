/********************************************************************************************************************************
* HeapSort is a comparison-based sorting algorithm.  HeapSort was invented by J. W. J. Williams in 1964                         *
* Time Complexity Best: O(n*log n), Average: O(n*log n), Worst : O(n*log n)                                                     *
* Space Complexity O(1)                                                                                                         *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class HeapSort
{
    /// <summary>
    /// The max-heap is selected for comparision.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr, arr.Length);
        sw.Stop();
        Console.WriteLine($"HeapSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr, int n)
    {
        // Getting Max-Heap
        var loop = n / 2 - 1;
        for (var i = loop; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        // Sorting Heap
        for (var i = n - 1; i >= 0; i--)
        {
            // sway root and end of array
            (arr[0], arr[i]) = (arr[i], arr[0]);

            // make highest element at root again, break last item from heap
            Heapify(arr, i, 0);
        }
    }

    private static void Heapify(int[] arr, int n, int i)
    {
        var largest = i;
        var left = 2 * i + 1;
        var right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}