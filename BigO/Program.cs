using BigO.ArraySorting;

const int size = 100000;
var baseArr = ArrayCreator.CreateRandomArray(size);

var arr1 = QuickSort.Run(baseArr);
var arr2 = MergeSort.Run(baseArr);
var arr3 = InsertionSort.Run(baseArr);
var arr4 = SelectionSort.Run(baseArr);
var arr5 = BubbleSort.Run(baseArr);

Array.Sort(baseArr);
ArrayComparator.Compare(baseArr, arr1, arr2, arr3, arr4, arr5);