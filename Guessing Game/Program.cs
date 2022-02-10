using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Timers;

namespace Guessing_Game
{
    class Program
    {
        public static Timer aTmr = new Timer(1000);
        public static int secondsCount = 0;
        public static int total = 0;
        public static int correctCount = 0;

        static void Main(string[] args)
        {

            aTmr.Elapsed += ATmr_Elapsed;
            aTmr.Enabled = true;
            aTmr.AutoReset = true;
            aTmr.Start();


            string content = "This is Really fun. I am Learning to code.  ";
            char[] list = new char[] { ' ', '.' };

            var split = content.ToLower().Split(list, StringSplitOptions.RemoveEmptyEntries);


        START:
            Random random = new Random();

            int i = random.Next(split.Length);

            Console.WriteLine("\n" + split[i]);

            string secretWord;
            if (split[i] == "code")
            {
                secretWord = "code";
            }
            else
            {
                secretWord = split[i + 1];
            }

            int scor = 0;
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;

            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess:");
                    guess = Console.ReadLine().ToLower();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }





            if (guessCount == 1 && outOfGuesses == false)
            {
                correctCount++;
                scor = +6;
            }
            else if (guessCount == 2 && outOfGuesses == false)
            {
                correctCount++;
                scor = +4;
            }
            else if (guessCount == 3 && outOfGuesses == false)
            {
                correctCount++;
                scor += 2;
            }
            else
            {
                scor += 0;
            }
            total += scor;


            Console.WriteLine("\nContinue ? (Y/Other)");
            Console.WriteLine("\n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                goto START;
            }
            else
            {
                Console.WriteLine("\nTotal points earned: " + total);
                Console.WriteLine("The number of straight word pairs found: " + correctCount);
                Console.WriteLine("Total number of checked word pairs: " + guessCount);
            }

            Console.ReadKey();

        }
        private static void ATmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            secondsCount++;
            //Console.WriteLine(secondsCount + " Seconds"); 
            if (secondsCount == 20)  //20 second
            {
                Console.WriteLine("\nTotal points earned: " + total);
                Console.WriteLine("The number of straight word pairs found: " + correctCount);
             
                System.Environment.Exit(0);         
            }
        }
    }
}
