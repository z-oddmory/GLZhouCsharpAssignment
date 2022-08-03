using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.What happens when you divide an int variable by 0?
            int i = 3;
            //int ans_a = 3 / 0;
            //Error: Division by constant zero

            //2.What happens when you divide a double variable by 0?
            double j = 4.5;
            double ans_b = j / 0;
            //Console.WriteLine($"ans_b = {ans_b}");
            //Console.ReadKey();
            //A double number can be devided by 0 and the answer is infinity.

            //3.What happens when you overflow an int variable,
            //that is, set it to a value beyond its
            //range?
            //int a = 14000000000000;
            //int can not be implicitly converted to long data type.

            //4.What is the difference between x = y++; and x = ++y;?
            //For x = y++, the value of y will be assigned to x and y will increase by 1. So x = y.
            //For x = ++y, y increases by 1 and the value will be assigned to x. So x = y + 1.

            //5.What is the difference between break, continue, and return when used inside a loop
            //statement ?
            //Break leaves the loop and continue jumps to the next iteration. Return: return a value and the loop stops.

            //6.What are the three parts of a for statement and which of them are required?
            //Three parts: initialization, condition and iterator. All of them are required(?).



            //7. What is the difference between the = and == operators?
            // = : the right side vaule will be assigned to left side.
            // == : checks whether the two given operands are equal or not.

            //8. Does the following statement compile? for ( ; true; ) ;
            for (; true;) ;
            //Yes.

            //9.What does the underscore _ represent in a switch expression?
            //The underscore (_) character replaces the default keyword to signify that it should match anything if reached.

            //10.What interface must an object implement to be enumerated over by using the foreach statement?


        }
    }
}
