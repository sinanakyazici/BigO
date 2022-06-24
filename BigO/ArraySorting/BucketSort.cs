/********************************************************************************************************************************
* Bucket sort, or bin sort, is a sorting algorithm that works by distributing the elements of an array into a number of buckets.*
* Time Complexity Best: O(n + k), Average: O(n), Worst : O(n^2)                                                                 *
* Space Complexity O(n + k)                                                                                                         *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class BucketSort
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
        Console.WriteLine($"BucketSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr, int n)
    {
        var max = arr.Max();
        var min = arr.Min();

        var k = (max - min) / 100;

        var buckets = new List<int>[k + 1];

        for (var i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        for (var i = 0; i < n; i++)
        {
            var j = (k * (long)(arr[i] - min)) / (max - min);
            buckets[j].Add(arr[i]);
        }

        var index = 0;
        for (var i = 0; i < buckets.Length; i++)
        {
            var temp = buckets[i].ToArray();
            InsertionSort.SortArray(temp);
            buckets[i] = temp.ToList();
            for (var j = 0; j < buckets[i].Count; j++)
            {
                arr[index++] = buckets[i][j];
            }
        }
    }
}