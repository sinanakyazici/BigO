namespace BigO.ArraySorting;

public class ArrayComparator
{
    public static void Compare(params int[][] arrays)
    {
        for (var i = 1; i < arrays.Length; i++)
        {
            var sequenceEqual = arrays[i-1].SequenceEqual(arrays[i]);
            if (sequenceEqual == false)
            {
                Console.WriteLine("Error: The arrays have been sorted are not the same.");
                break;
            }
        }
    }
}