using System;
using static Sorting.BubbleSort;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bsort = new BubbleSort();
            int[] unsorted = { 3, 6, 4, 2, 5, 1, 2, 7, 10, 9, 7, 8, 11, 12, 3 };
            bsort.BubbleSortAlg(unsorted);

            foreach (int i in unsorted)
            {
                Console.WriteLine(i);
            }

        }
    }
}
