using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sorting
{
    public class BubbleSort
    {
        public void BubbleSortAlg(int[] array1)
        {
            int temp = 0;
            int swaps = 0; 
            for (int i = 0; i <array1.Length - 1; i++)
            {
                for (int j = i + 1; j<array1.Length; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                        swaps += 1;
                    }
                }
            }
            Console.WriteLine(swaps);
        }
    }

}