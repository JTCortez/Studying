using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class MergeSort
    {
        public List<int> MergeSortHelper(List<int> array)
        {
            if (array.Count == 1)
                return array;

            
            List<int> arrayOne = new List<int>(array.GetRange(0, array.Count/2));
            List<int> arrayTwo = array.GetRange(array.Count / 2, array.Count / 2);

            arrayOne = MergeSortHelper(arrayOne);
            arrayTwo = MergeSortHelper(arrayTwo);

            return Merge(arrayOne, arrayTwo);
        }

        public List<int> Merge(List<int> a, List<int> b)
        {
            List<int> c = new List<int>(a.Count + b.Count);

            int aIndex = 0;
            int bIndex = 0;
            int cIndex = 0;

            while (aIndex <= a.Count - 1 && bIndex <= b.Count - 1)
            {
                if (a[aIndex] > b[bIndex])
                {
                    c.Add(b[bIndex]);
                    bIndex += 1;
                }
                else
                {
                    c.Add(a[aIndex]);
                    aIndex += 1;
                }
            }

            while (aIndex <= a.Count - 1)
            {
                c.Add(a[aIndex]);
                aIndex += 1;
            }

            while (bIndex <= b.Count - 1)
            {
                c.Add(b[bIndex]);
                bIndex += 1;
            }
            return c;
        }
    }
}
