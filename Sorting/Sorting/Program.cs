using System;
using static Sorting.BubbleSort;
using static Sorting.SelectionSort;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bsort = new BubbleSort();
            int[] unsorted = { 3, 6, 4, 2, 5, 1, 2, 7, 10, 9, 7, 8, 11, 12, 3 };
            bsort.BubbleSortAlg(unsorted);

            SelectionSort sSort = new SelectionSort();
            int[] unsorted2 = { 3, 6, 4, 2, 5, 1, 2, 7, 10, 9, 7, 8, 11, 12, 3 };
            sSort.SelectionSortAlg(unsorted2);

            foreach (int i in unsorted)
            {
                Console.Write(i + ",");
            }


            Console.WriteLine(" ");

            foreach (int i in unsorted2)
            {
                Console.Write(i + ",");
            }
            return;
        }
    }
}
