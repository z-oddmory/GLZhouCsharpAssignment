using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLZhouCsharpAssignment
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite movie?");
            string movie = Console.ReadLine();
            Console.WriteLine("What's your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What's your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine($"Your new name is {movie}{color}{animal}");
            Console.ReadKey();

        }
    }
}
