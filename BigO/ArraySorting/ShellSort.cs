/********************************************************************************************************************************
* Shell sort or Shell's method, is an in-place comparison sort. Donald Shell published the first version of this sort in 1959   *
* Time Complexity Best: O(n*log n), Average: O(n*log n), Worst : O(n^2)                                                         *
* Space Complexity O(1)                                                                                                         *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class ShellSort
{
    /// <summary>
    /// The original sequence is selected for comparision.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static int[] Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr, arr.Length);
        sw.Stop();
        Console.WriteLine($"ShellSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
        return arr;
    }

    private static void SortArray(int[] arr, int n)
    {
        for (var i = n / 2; i > 0; i /= 2)
        {
            for (var x = i; x < n; x++)
            {
                var temp = arr[x];
                int y;
                for (y = x; y >= i && arr[y - i] > temp; y -= i)
                {
                    arr[y] = arr[y - i];
                }

                arr[y] = temp;
            }
        }

    }
}