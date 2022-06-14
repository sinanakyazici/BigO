/********************************************************************************************************************************
* Merge sort is a divide-and-conquer algorithm that was invented by John von Neumann in 1945                                    *
* Time Complexity Best: O(n*log n), Average: O(n*log n), Worst : O(n*log n)                                                     *
* Space Complexity O(n)                                                                                                         *
********************************************************************************************************************************/

namespace BigO.ArraySorting;

public class MergeSort
{
    /// <summary>
    /// The middle item of array is selected to divide.
    /// </summary>
    /// <param name="baseArr">The array that will be sorted.</param>
    public static void Run(int[] baseArr)
    {
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr, 0, arr.Length - 1);
        sw.Stop();
        Console.WriteLine($"MergeSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
    }

    private static void SortArray(int[] arr, int first, int last)
    {
        if (first < last)
        {
            var mid = (first + last) / 2;
            SortArray(arr, first, mid);
            SortArray(arr, mid + 1, last);
            MergeArray(arr, first, mid, last);
        }
    }

    private static void MergeArray(int[] arr, int first, int mid, int last)
    {
        var n1 = mid + 1 - first;
        var n2 = last - mid;

        var a1 = new int[n1];
        var a2 = new int[n2];

        Array.Copy(arr, first, a1, 0, n1);
        Array.Copy(arr, mid + 1, a2, 0, n2);

        int x = 0, y = 0, z = first;

        while (true)
        {
            if (x < n1 && y < n2 && a1[x] <= a2[y])
            {
                arr[z] = a1[x];
                x++;
            }
            else if (x < n1 && y < n2 && a1[x] > a2[y])
            {
                arr[z] = a2[y];
                y++;
            }
            else if(x < n1 && y >= n2)
            {
                arr[z] = a1[x];
                x++;
            }
            else if (x >= n1 && y < n2)
            {
                arr[z] = a2[y];
                y++;
            }
            else
            {
                break;
            }

            z++;
        }
    }
}