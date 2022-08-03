using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a_array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            int[] newArray = new int[a_array.Length];

            for(int i = 0; i < a_array.Length; i++)
            {
                newArray[i] = a_array[i];
            }
            Console.WriteLine("The elements of a_array:");
            for(int i = 0; i < a_array.Length; i++)
            {
                Console.WriteLine($"The {i} element is {a_array[i]}");
            }

            Console.WriteLine("The elements of newArray:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"The {i} element is {newArray[i]}");
            }

            Console.ReadKey();

            //other method:firstly using list then using list.ToArray()


        }
    }
}
