using System;
using static DynamicProgramming.TripleStep;
using static DynamicProgramming.fib;
using static DynamicProgramming.robotinagrid;
using System.Collections.Generic;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            TripleStep dp = new TripleStep();
            int ans = dp.TripleStepFunction(n);
            Console.WriteLine(ans);

            fib fibb = new fib();
            int fans = fibb.FibHelp(n);
            Console.WriteLine(fans);

            robotinagrid robo = new robotinagrid();
            bool[,] array2D = new bool[,] { 
                { true, true, true, true, true, false}, 
                { true, true, false, true, false, true},
                { true, true, true, false, false, true},
                { false, true, true, true, true, true},
                { true, true, true, false, false, true}, 
                { true, false, true, true, true, true},};
            bool[,] check = new bool[array2D.GetLength(0), array2D.GetLength(1)];

            //Console.WriteLine(check.GetLength(0));
            List<(int, int)> paths = robo.RobotInGrid(array2D);
            foreach (var path in paths)
            {
                Console.WriteLine("({0}, {1})", path.Item1, path.Item2);
            }


        }
    }
}
