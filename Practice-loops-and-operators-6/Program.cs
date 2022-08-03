using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops_and_operators_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outerLoop = 5;
            int biggestValue = 24;
            int value = 0;
            for(int i = 1; i < outerLoop; i++)
            {
                for (int j = 0; j < biggestValue + 1; j++)
                {
                    if (j == biggestValue)
                    {
                        Console.WriteLine($"{j}\n");
                    }
                    else if (j % i == 0)
                    {   
                        
                        Console.Write($"{j},");
                        
                    }
                    
                }
            }
            Console.ReadKey();

        }
    }
}
