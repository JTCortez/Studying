using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class SelectionSort
    {
        public void SelectionSortAlg(int[] arr)
        {
            int swaps = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int small = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[small] > arr[j])
                    {
                        small = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[small];
                arr[small] = temp;
                swaps += 1;
            }
            Console.WriteLine(swaps);
        }
    }

    public void selectionSortAlgo(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int small = i;
            for (int j = i + 1; i < arr.Length; j++)
            {
                if (arr[small] > int[j])
                {
                    small = j;
                }
                int temp = arr[i];
                arr[i] = arr[small];
                arr[small] = temp;

            }
        }
    }
}
