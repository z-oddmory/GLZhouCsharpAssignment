using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Arrays_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] anArray = { 3, 2, 4, -1 };
            sumRotateArray(anArray);
            Console.ReadKey();
        }
        static int[] sumRotateArray(int[] anArray)
        {
            int[] copyArray = anArray;
            string a = Console.ReadLine();
            int k =  Int32.Parse(a);
            for (int i = 0; i < anArray.Length; i++)
            {
                anArray[i] = copyArray[(i+k)%(anArray.Length)];
            }
            return anArray;
        }
        
    }
}
