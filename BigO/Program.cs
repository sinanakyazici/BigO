using BigO.ArraySorting;

const int size = 100000;
var baseArr = ArrayCreator.CreateRandomArray(size);

var arr1 = QuickSort.Run(baseArr);
var arr2 = MergeSort.Run(baseArr);
var arr3 = InsertionSort.Run(baseArr);

ArrayComparator.Compare(arr1, arr2, arr3);