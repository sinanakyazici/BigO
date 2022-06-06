namespace BigO.ArraySorting;

public class QuickSort
{
    /// <summary>
    /// QuickSort has O(n log(n)) time complexity and O(log(n)) space complexity. The last item of array is selected for pivot.
    /// </summary>
    /// <param name="size"></param>
    public static void Run(int size)
    {
        var baseArr = CreateRandomArray(size);
        var arr = (int[])baseArr.Clone();
        var sw = new Stopwatch();
        sw.Start();
        SortArray(arr, 0, arr.Length - 1);
        sw.Stop();
        Console.WriteLine($"QuickSort Elapsed Time : {sw.ElapsedMilliseconds} ms");
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

    private static int[] CreateRandomArray(int size)
    {
        var array = new int[size];
        var rand = new Random();
        for (var i = 0; i < size; i++)
        {
            array[i] = rand.Next(0, size < 100 ? 100 : size);
        }

        return array;
    }
}