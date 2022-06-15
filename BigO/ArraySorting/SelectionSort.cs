/********************************************************************************************************************************
* In computer science, selection sort is an in-place comparison sorting algorithm.                                              *
* Time Complexity Best: O(n^2), Average: O(n^2), Worst : O(n^2)                                                                 *
* Space Complexity O(1)                                                                                                         *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class SelectionSort
{
    /// <summary>
    /// The min item of array is selected for compare.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr);
        sw.Stop();
        Console.WriteLine($"SelectionSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr)
    {
        for (var j = 0; j < arr.Length; j++)
        {
            var min = j;
            for (var i = min + 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }

            (arr[j], arr[min]) = (arr[min], arr[j]);
        }
    }
}