using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class MessageInput
    {
        public static void Messages()
        {
            Console.WriteLine("Do you want to play a game(in jigsaw voice)?");
            Console.WriteLine();
            Console.WriteLine("The game is Hangman, you must guess the fruit before you run out of lives");
            Console.WriteLine();
            Console.WriteLine("The clock is ticking");
            Console.WriteLine();
        }

        public static void EndMessages(int LivesRemaining, string chosenWord)
        {
            if (LivesRemaining == 0)
            {
                Console.WriteLine("You have ran out of lives. You lose!");
                Console.WriteLine("The word was: {0}", chosenWord);
            }
            else
            {
                Console.WriteLine("You have won the game!");
            }
        }

        public static void EndMessages()
        {
            throw new NotImplementedException();
        }
    }
}