namespace BigO.ArraySorting;

public class ArrayComparator
{
    public static void Compare(int[] baseArr, params int[][] arrays)
    {
        var temp = (int[])baseArr.Clone();
        Array.Sort(temp);

        for (var i = 0; i < arrays.Length; i++)
        {
            var sequenceEqual = temp.SequenceEqual(arrays[i]);
            if (sequenceEqual == false)
            {
                Console.WriteLine("Error: The arrays have been sorted are not the same.");
                break;
            }
        }
    }
}