using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes_CenturyConvertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int century = Int32.Parse(Console.ReadLine());
            int years = century * 100;
            int days = Convert.ToInt32(years * 365.242196);//(36524/100) and (182621/500) --> choose which value
            int hours = days * 24;
            int minutes = hours * 60;       
            long seconds = (long)minutes * 60;
            long milliseconds = seconds * 1000;
            ulong microseconds = (ulong)milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;
            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            long i = 15778454400000000;
            Console.ReadKey();
            //double score = 8.5;
            //int i1 = Convert.ToInt32(score);
            //int i2 = (int)score;
            //Console.WriteLine(i2);
            //Console.WriteLine("i2:", i2);
           //Console.ReadKey();
        }
    }
}
