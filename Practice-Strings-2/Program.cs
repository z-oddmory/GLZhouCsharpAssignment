using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Strings_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "C# is not C++, and PHP is not Delphi!";
            //string ss = Convert.ToString(s[-1]);
            //Console.WriteLine(ss);
            string newS = ReverseString(s);
            Console.WriteLine(newS);
            //string newS = "";
            //string[] words = s.Split(' ');
            ////foreach (string word in words)
            ////{
            ////    Console.WriteLine(word);
            ////}
            //string[] newWords = new string[words.Length];
            //for(int i = words.Length - 1; i >= 0 ; i--)
            //{
            //    newWords.Append(words[i]);
            //}
            //foreach (string word in newWords)
            //{
            //    Console.WriteLine(word);
            //}

            //newS = string.Join(" ", newWords);
            //Console.WriteLine(newS);
            Console.ReadKey();
            //CAN NOT FIX THE PUNCTUATION PROBLEM
        }
        public static string ReverseString(string text)
        {
            string[] words = text.Split(' ');
            Array.Reverse(words);

            return string.Join(" ", words);
        }
    }
}
