using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayStrings
{
    class PaliPerm
    {
        public bool PalindromePermutation(string phrase)
        {
            Hashtable strTable = new Hashtable();
            int maxOdd = 1;
            foreach (char c in phrase.ToLower())
            {
                if (c == ' ') continue;
                if (strTable.ContainsKey(c) == false)
                {
                    strTable.Add(c, 1);
                }
                else
                {
                    Console.WriteLine(c);
                    strTable[c] = (int)strTable[c] + 1;
                }
            }

            foreach (int num in strTable.Values)
            {
                if (num % 2 == 1)
                {
                    maxOdd -= 1;
                }
            }

            return maxOdd >= 0 ? true: false;
        }
    }
}
