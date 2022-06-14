using BigO.ArraySorting;

const int size = 1000000;
var baseArr = ArrayCreator.CreateRandomArray(size);

var arr1 = QuickSort.Run(baseArr);
var arr2 = MergeSort.Run(baseArr);
var arr3 = InsertionSort.Run(baseArr);