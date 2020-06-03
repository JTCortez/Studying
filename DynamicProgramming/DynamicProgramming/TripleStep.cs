using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class TripleStep
    {
        public int TripleStepFunction(int n)
        {
            return TSHelp(n, new int[n + 1]);
        }

        public int TSHelp (int n, int[] memo)
        {
            //27, different because I included extra step, 4 steps is 5
            if (n <= 0) return 0;
            else if (n == 1) return 1;
            else if (n == 2) return 2;
            else
            {
                memo[n] = TSHelp(n - 1, memo) + TSHelp(n - 2, memo) + TSHelp(n - 3, memo);
            }

            return memo[n];
        }
    }
}
