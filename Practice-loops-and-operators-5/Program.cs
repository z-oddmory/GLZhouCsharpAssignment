using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops_and_operators_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime(2015, 1, 1, 4, 56, 4);

            //DateTime now = DateTime.Now;
            //morning:6 - 12; afternoon:12-18; evening:18 - 0; night:0-6
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 24)
            {
                Console.WriteLine("Good Evening");
            }
            if (DateTime.Now.Hour >= 0  && DateTime.Now.Hour < 6)
            {
                Console.WriteLine("Good Night");
            }
            //Console.WriteLine(DateTime.Now.Hour);
            Console.ReadKey();
        }
    }
}
