using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_02
{
    internal class NumberGuessing
    {
       static Random rand = new Random();
        public  void Guessing()
        {
            int low = 1;
            int high = 100;
            bool isGuessed = false;
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("Respond with:");
            Console.WriteLine("h -> Too High | l -> Too Low | c -> Correct\n");
            while (!isGuessed)
            {
                int guess = GenerateGuess(low, high);
                Console.WriteLine("Computer guess: " + guess);
                char feedback = GetUserFeedback();
                isGuessed = ProcessFeedback(feedback, guess, ref low, ref high);
            }
            Console.WriteLine("\n🎉 Computer guessed your number correctly!");
        }
        // Method to generate a random guess
        static int GenerateGuess(int low, int high)
        {
            return rand.Next(low, high + 1);
        }
        // Method to get user feedback
        static char GetUserFeedback()
        {
            Console.Write("Enter feedback (h/l/c): ");
            return Convert.ToChar(Console.ReadLine().ToLower());
        }
        // Method to process feedback and update range
        static bool ProcessFeedback(char feedback, int guess, ref int low, ref int high)
        {
            if (feedback == 'h')
            {
                high = guess - 1;
            }
            else if (feedback == 'l')
            {
                low = guess + 1;
            }
            else if (feedback == 'c')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter h, l, or c.");
            }
            return false;
        }
    }

}
