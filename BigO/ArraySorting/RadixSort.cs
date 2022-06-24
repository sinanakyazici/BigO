/********************************************************************************************************************************
* In computer science, radix sort is a non-comparative sorting algorithm. the work of Herman Hollerith on tabulating machines.  *
* Time Complexity Best: O(nk), Average: O(nk), Worst : O(nk)                                                                    *
* Space Complexity O(n + k)                                                                                                     *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class RadixSort
{
    /// <summary>
    /// The radix approach is selected for comparision.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr, arr.Length);
        sw.Stop();
        Console.WriteLine($"RadixSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr, int n)
    {
        var max = arr.Max();
        for (var d = 1; max / d > 0; d *= 10)
        {
            ArrangeArray(arr, n, d);
        }
    }

    private static void ArrangeArray(int[] arr, int n, int d)
    {
        var counts = new int[10];
        var output = new int[n];

        for (var i = 0; i < n; i++)
        {
            var index = (arr[i] / d) % 10;
            counts[index]++;
        }

        for (var i = 1; i < 10; i++)
        {
            counts[i] += counts[i - 1];
        }

        for (var i = n - 1; i >= 0; i--)
        {
            var index = (arr[i] / d) % 10;
            counts[index]--;
            output[counts[index]] = arr[i];
        }

        for (var i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }
}