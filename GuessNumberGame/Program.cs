using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(3) + 1;
            while (true)
            {
                Console.WriteLine("Please enter your guess number:");
                int guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber < 1  || guessedNumber > 3 )
                {
                    Console.WriteLine($"Your guess {guessedNumber} is outside of range which is [1,3]");
                    Console.WriteLine("Guess is lower than the random. Try again.");
                }
                else if(guessedNumber > randomNumber)
                {
                    Console.WriteLine("Guess is greater than the random. Try again.");
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Guess is less than the random. Try again.");
                }
                else
                {
                    Console.WriteLine($"The random number is {guessedNumber}. You win.");
                    break;
                }
               
            }
            //Console.WriteLine(randomNumber);
            Console.ReadKey();
        }
    }
}
