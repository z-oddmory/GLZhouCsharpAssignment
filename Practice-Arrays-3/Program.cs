using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Arrays_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindPrimesInRange(1, 7);
        }
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] numbers = new int[endNum-startNum + 1];
            int[] newArray = new int[endNum - startNum + 1];
            for (int i = startNum; i< endNum + 1; i++)
            {
                numbers.Append(i);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = numbers[0]; j < numbers[numbers.Length - 1]+1; j++)
                {
                    //if (j %)
                }
            }
            return null;//this is an array of integers
        }
    }
}
