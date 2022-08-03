using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(' ' * 7 + 'i' + ' ' * 7);
            //Console.ReadKey();
            //Console.WriteLine(new string('*', 7) + 'i'); 
            //Console.ReadKey();
            int lineNum = int.Parse(Console.ReadLine());
            for (int i = 1; i < lineNum+1; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(new string(' ', (lineNum - i)/2) + new string('*', i) + new string(' ', (lineNum - i) / 2));

                }
                        
            }
            Console.ReadKey();
        }
    }
}
