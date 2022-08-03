using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatwillhappen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
                if (i > 254)
                {
                    Console.WriteLine($"byte's max value is {byte.MaxValue}. Using if statement to help us stop the infinite loop.");
                    break;
                }

            }

            //After pasting the codes into Visio, we get an error:"The name 'WriteLine' does not exist in the current context";
            //And the program does not stop.)
            //Console.WriteLine($"byte's max value:{byte.MaxValue}");
            Console.ReadKey();

        }
    }
}
