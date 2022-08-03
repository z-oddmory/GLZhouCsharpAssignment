using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] anArray = { 3, 2, 4, -1 };
            int[] copyArray = anArray;
            string a = Console.ReadLine();
            int k = Int32.Parse(a);
            for (int i = 0; i < anArray.Length; i++)
            {
                anArray[i] = copyArray[(i + k) % (anArray.Length)];
            }
            for (int i = 0; i < anArray.Length; i++)
            {
                Console.WriteLine(anArray[i]);
            }
            Console.ReadKey();

            //python deepcopy an array a -> b c - > b, when one of a's element change c will stay the same
            // use the formula (I + r) % n to get a new array
            // for - loop to get the answer
        }
    }
}
