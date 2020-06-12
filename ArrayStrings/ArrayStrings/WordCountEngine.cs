using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrayStrings
{
    public class WordCountEngine
    {
        public class Word
        {
            public int index;
            public String word;
            public int repeat;

            public Word(int index, String word, int repeat)
            {
                this.index = index;
                this.word = word;
                this.repeat = repeat;
            }
        }

        public void WordCount(string document)
        {
            // your code goes here
            Dictionary<string, Word> table = new Dictionary<string, Word>();


            string str = document;
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");

            str = rgx.Replace(str.ToLower(), "");
            string[] wordArr = new string[0];
            wordArr = str.Split(wordArr, StringSplitOptions.None);
            int index = 0;

            foreach (string w in wordArr)
            {
                Word newWord = new Word(index, w, 1);
                if (!table.ContainsKey(w))
                {
                    table.Add(w, newWord);
                }
                else
                {
                    table[w].repeat = table[w].repeat + 1;
                }
                index += 1;
                table[w].index = index;
            }
            //Queue<Word> q = new Queue<Word>();
            //Queue<Word> pQ = Queue<Word>();
            List<List<string>> final = new List<List<string>>();

            foreach (Word w in table.Values)
            {
                final.Add(new List<string> { w.word, w.repeat.ToString(), w.index.ToString()});
            }

            foreach (List<string> li in final)
            {
                foreach (string s in li)
                {
                    Console.Write("{0},", s);
                }
                Console.WriteLine("");
            }



            //List<List<string>> stringArr = new List<List<string>();

            //foreach (Word w in que)
            //{
            //    stringArr.Add({ w.word, w.repeat});
            //}

            //return stringArr.ToArray();

            //pQ.sort(func=>)


        }
    }
}
