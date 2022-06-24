/********************************************************************************************************************************
* Insertion sort was mentioned by John Mauchly as early as 1946, in the first published discussion on computer sorting.         *
* Time Complexity Best: O(n), Average: O(n^2), Worst : O(n^2)                                                                   *
* Space Complexity O(1)                                                                                                         *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class InsertionSort
{
    /// <summary>
    /// The next item of array is selected for key.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr);
        sw.Stop();
        Console.WriteLine($"InsertionSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    public static void SortArray(int[] arr)
    {
        for (var i = 1; i < arr.Length; i++)
        {
            var key = arr[i];
            var j = i - 1;
            while (j >= 0 && key < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}