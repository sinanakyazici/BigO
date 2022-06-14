using BigO.ArraySorting;

const int size = 10000000;
var baseArr = ArrayCreator.CreateRandomArray(size);

QuickSort.Run(baseArr);
MergeSort.Run(baseArr);
