/********************************************************************************************************************************
* Bucket sort, or bin sort, is a sorting algorithm that works by distributing the elements of an array into a number of buckets.*
* Time Complexity Best: O(n + k), Average: O(n + k), Worst : O(n + k)                                                           *
* Space Complexity O(n + k)                                                                                                     *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class BucketSortForInteger
{
    /// <summary>
    /// The scatter-gather approach is selected for comparision.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr, arr.Length);
        sw.Stop();
        Console.WriteLine($"BucketSortForInteger Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr, int n)
    {
        var max = arr.Max();
        var min = arr.Min();

        var k = (max - min);
        var buckets = new int[k + 1];

        for (var i = 0; i < n; i++)
        {
            var index = (arr[i] - min);
            buckets[index]++;
        }

        var t = 0;
        for (var i = 0; i < buckets.Length; i++)
        {
            for (var j = 0; j < buckets[i]; j++)
            {
                arr[t++] = i + min;
            }
        }
    }
}