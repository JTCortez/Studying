using System;
using System.Collections.Generic;
using System.Linq;
using static BitManipulation.InsertBit;

namespace BitManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = 200;
            int M = 3;
            int j = 4;
            int i = 2;
            int newBit;
            InsertBit iBit = new InsertBit();
            Console.WriteLine(Convert.ToString(N, 2));
            Console.WriteLine(Convert.ToString(M, 2));
            newBit = iBit.insertM(N, M, j, i);
            Console.WriteLine(Convert.ToString(newBit, 2));
        }
    }
}

