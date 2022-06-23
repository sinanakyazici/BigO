/********************************************************************************************************************************
* QuickSort is an in-place sorting algorithm. Developed by British computer scientist Tony Hoare in 1959 and published in 1961. *
* Time Complexity Best: O(n*log n), Average: O(n*log n), Worst : O(n^2)                                                         *
* Space Complexity O(log n)                                                                                                     *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class QuickSort
{
    /// <summary>
    /// The last item of array is selected for pivot.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr, 0, arr.Length - 1);
        sw.Stop();
        Console.WriteLine($"QuickSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr, int first, int last)
    {
        if (first < last)
        {
            var pivotIndex = ArrangeArray(arr, first, last);
            SortArray(arr, first, pivotIndex - 1);
            SortArray(arr, pivotIndex + 1, last);
        }
    }

    private static int ArrangeArray(int[] arr, int first, int last)
    {
        var pivot = arr[last];
        var pointer = first;
        for (var i = first; i <= last; i++)
        {
            if (arr[i] <= pivot)
            {
                (arr[i], arr[pointer]) = (arr[pointer], arr[i]);
                pointer++;
            }
        }

        return pointer - 1;
    }
}