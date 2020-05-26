using System;
using System.Collections.Generic;
using static Sorting.BubbleSort;
using static Sorting.SelectionSort;
using static Sorting.MergeSort;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BubbleSort bsort = new BubbleSort();
            //int[] unsorted = { 3, 6, 4, 2, 5, 1, 2, 7, 10, 9, 7, 8, 11, 12, 3 };
            //bsort.BubbleSortAlg(unsorted);

            //SelectionSort sSort = new SelectionSort();
            //int[] unsorted2 = { 3, 6, 4, 2, 5, 1, 2, 7, 10, 9, 7, 8, 11, 12, 3 };
            //sSort.SelectionSortAlg(unsorted2);

            MergeSort mSort = new MergeSort();
            int[] unsorted3 = { 2, 8, 5, 3, 9, 4, 1, 7 };
            List<int> unsortedlist = new List<int>(unsorted3);
            List<int> sorted = mSort.MergeSortHelper(unsortedlist);


            foreach (int i in sorted)
            {
                Console.Write(i + ",");
            }


            //Console.WriteLine(" ");

            //foreach (int i in unsorted2)
            //{
            //    Console.Write(i + ",");
            //}

            //foreach (int i in sorted)
            //{
            //    Console.Write(i + ",");
            //}
            return;
        }
    }
}
