using BigO.ArraySorting;

const int size = 100000;
var baseArr = ArrayCreator.CreateRandomArray(size);

var arr10 = RadixSort.Run(baseArr);
var arr1 = QuickSort.Run(baseArr);
var arr2 = MergeSort.Run(baseArr);
var arr6 = HeapSort.Run(baseArr);
var arr7 = ShellSort.Run(baseArr);
var arr8 = BucketSort.Run(baseArr);
var arr9 = CountingSort.Run(baseArr);

ArrayComparator.Compare(baseArr, arr1, arr2,  arr6, arr7, arr8, arr9, arr10);

var arr3 = InsertionSort.Run(baseArr);
var arr4 = SelectionSort.Run(baseArr);
var arr5 = BubbleSort.Run(baseArr);

ArrayComparator.Compare(baseArr, arr1, arr2, arr3, arr4, arr5, arr6, arr7, arr8, arr9, arr10);
