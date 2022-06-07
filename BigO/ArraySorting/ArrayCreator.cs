namespace BigO.ArraySorting;

public class ArrayCreator
{
    public static int[] CreateRandomArray(int size)
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