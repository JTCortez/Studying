using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    public class InsertBit
    {
        public int clearBits(int N, int j, int i)
        {
                int mask = ~(((1<<j - 1) - 1) << i);
                Console.WriteLine(Convert.ToString(mask, 2));
                return N & mask;
        }

        public int insertM(int N, int M, int j, int i)
        {
            int maskN = clearBits(N, j, i);
            Console.WriteLine(Convert.ToString(maskN, 2));
            int maskM = M << i;
            return maskN ^ maskM;
        }
    }
}
