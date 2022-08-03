using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Strings_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hi, exe? ABBA! Hog fully a string: ExE.Bob";
            Palindromes(sentence);
            //String[] words = sentence.Split(' ', '?', '!', ':', '.', ',');
            //foreach(String word in words)
            //{
            //    Console.WriteLine(word);
            //}
            Console.ReadKey();
        }
        public static string Palindromes(string text)
        {
            String[] words = text.Split(' ', '?', '!', ':', '.', ',');

            String[] newWords = new String[words.Length];
            
            //for(int i = 0; i< words.Length; i++)
            //{
            //    if(words[i] != " ")//!
            //    {
            //        Console.WriteLine(words[i]);
            //        newWords.Append(words[i]);
            //    }

            //}
            //foreach(String word in newWords)
            //{
            //    Console.WriteLine(word);
            //}
            Console.ReadKey();
            return null;
        }
    }
}
