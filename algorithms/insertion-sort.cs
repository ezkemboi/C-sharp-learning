using System;

namespace insertion_sort 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      int[] unsortedArr = {5, 2, 4, 6, 1, 3};
      InsertionSort(unsortedArr);
      print(unsortedArr);
    }
    // create a method for perfoming insertion sort
    static void InsertionSort(int[] arr) {
      // sort array
      for (int i = 1; i < arr.Length; i++) {
        int temp = arr[i];
        int j = i - 1;
        while(j >= 0 && arr[j] > temp) {
          arr[j + 1] = arr[j];
          j = j - 1;
        }
        arr[j + 1] = temp;
      }
    }

    static void print(int[] arr) {
      for(int i = 0; i < arr.Length; i++) {
        Console.WriteLine(arr[i]); // 1, 2, 3, 4, 5, 6
      }
    }
  }
}