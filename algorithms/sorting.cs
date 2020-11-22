using System;
using System.Linq;

namespace insertion_sort 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      int[] unsortedArr = {5, 2, 4, 6, 1, 3};
      int[] sortedArr = {1, 2, 3, 4, 5, 6};
      InsertionSort(unsortedArr);
      if(checkEquality(unsortedArr, sortedArr)) {
        Console.WriteLine("Equal");
      } 
      else {
        Console.WriteLine("Not Equal");
      }
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
    static bool checkEquality(int[] first, int[] second) {
      return Enumerable.SequenceEqual(first, second);
    }
  }
}