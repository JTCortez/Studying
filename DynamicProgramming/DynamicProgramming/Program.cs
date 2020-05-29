using System;
using static DynamicProgramming.TripleStep;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            TripleStep dp = new TripleStep();
            int ans = dp.TripleStepFunction(n);
            Console.WriteLine(ans);
        }
    }
}
