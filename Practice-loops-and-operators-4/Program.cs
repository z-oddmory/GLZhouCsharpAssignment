using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops_and_operators_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1995, 1, 1);
            DateTime now = DateTime.Now;
            int days = Convert.ToInt32((now - dt).TotalDays);
            int nextThousandDays = 10000;
            int allDays = days + nextThousandDays;
            int yearDays = 365;
            int monthDays = 30;
            int futureYear = (nextThousandDays / yearDays) + now.Year;
            int futureMonth = (nextThousandDays % yearDays) / monthDays;
            int futureDays = (nextThousandDays % yearDays) % monthDays;
            Console.WriteLine($"The date of next {nextThousandDays} is '{futureMonth}/{futureDays}/{futureYear}'.");
            Console.ReadKey();
        }
    }
}
