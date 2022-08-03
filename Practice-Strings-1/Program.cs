using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Strings_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1
            string s = "sample";
            string newS = "";
            char[] sCharArray = s.ToCharArray();
            char[] newArray = new char[sCharArray.Length];

            Array.Reverse(sCharArray);
            //foreach (char ch in sCharArray)
            //{
            //    Console.Write(ch);
            //}
            newS = string.Join("", sCharArray);
            Console.WriteLine(newS);
            
            //Method 2
            string s1 = "24tvcoi92";
            string newS1 = "";
            for(int i = s1.Length -1 ; i >= 0 ; i--)
            {
                newS1 += s1[i];
            }
            Console.WriteLine(newS1);
            Console.ReadKey();
        }
    }
}
