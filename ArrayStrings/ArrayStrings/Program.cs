using System;
using static ArrayStrings.PaliPerm;
namespace ArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            PaliPerm pp = new PaliPerm();

            Console.WriteLine(pp.PalindromePermutation("Tacto Coasf"));
        }
    }
}
