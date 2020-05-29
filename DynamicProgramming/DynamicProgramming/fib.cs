using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class fib
    {
        public int FibHelp(int n)
        {
            return Fibbonaci(n, new int[n + 1]);
        }

        int Fibbonaci(int n, int[] memo)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            int a = 1;
            int b = 0;
            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                b = a;
                a = c;
            }

            return a + b;
        }
    }
}
