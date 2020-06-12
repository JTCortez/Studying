using System;
using System.Text.RegularExpressions;
using static ArrayStrings.PaliPerm;
using static ArrayStrings.WordCountEngine;
namespace ArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            PaliPerm pp = new PaliPerm();
            WordCountEngine wce = new WordCountEngine();

            int[,] a = new int[3,3] { { 1,1,1}, { 2,2,2}, { 3,3,3} };

            Console.Write("{0}, {1} =>", a.GetLength(0), a.GetLength(1));

            string str = "Practice makes perfect. you'll only get Perfect by practice. just practice!";
            Console.WriteLine(pp.PalindromePermutation("Tacto Coasf"));
            wce.WordCount(str);
            //Console.WriteLine(str);
        }
    }
}
