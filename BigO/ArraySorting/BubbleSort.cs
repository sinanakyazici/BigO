/********************************************************************************************************************************
* Bubble sort, sometimes referred to as sinking sort                                                                            *
* Time Complexity Best: O(n), Average: O(n^2), Worst : O(n^2)                                                                   *
* Space Complexity O(1)                                                                                                         *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class BubbleSort
{
    /// <summary>
    /// The next item of array is selected for comparision.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr);
        sw.Stop();
        Console.WriteLine($"BubbleSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr)
    {
        var swapFlag = false;
        for (var j = 1; j < arr.Length - 1; j++)
        {
            for (var i = 0; i < arr.Length - j; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapFlag = true;
                }
            }

            if (swapFlag == false) break;
        }
    }
}