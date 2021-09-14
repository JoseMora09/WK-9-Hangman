using System;
using System.Collections.Generic;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {

            MessageInput.Messages();


            string[] wordList = { "apple" , "orange", "grape" , "pear", "strawberry"};


            Random random = new Random();
            int wordListInt = random.Next(0, wordList.Length - 1);

            string chosenWord = wordList[wordListInt].ToLower();
            Console.WriteLine("The word has {0} characters", chosenWord.Length);

            int LivesRemaining = 7;
            List<string> alreadyGuessedLetters = new List<string>();
            string displayWord = "";

            while (LivesRemaining > 0 && displayWord != chosenWord)
            {
                Console.WriteLine("Remaining attempts: {0}", LivesRemaining);


                Console.WriteLine("Enter a letter: ");
                char[] input = Console.ReadLine().ToCharArray();

                string guess = "";
                if (input.Length > 0)
                {
                    guess = input[0].ToString();
                    guess = guess.ToLower();
                }

                alreadyGuessedLetters.Add(guess);

                displayWord = "";
                string containedMessage = "";
                if (chosenWord.Contains(guess))
                {
                    containedMessage = "{0} is contained in the word.";
                }
                else
                {
                    containedMessage = "{0} is NOT contained in the word.";
                    LivesRemaining--;
                }

                Console.WriteLine(containedMessage, guess);

                foreach (var letter in chosenWord)
                {
                    if (alreadyGuessedLetters.Contains(letter.ToString()))
                    {
                        displayWord += letter;
                    }
                    else
                    {
                        displayWord += "*";
                    }
                }

                Console.WriteLine(displayWord);
                Console.WriteLine();
            }

            if (LivesRemaining == 0)
            {
                MessageInput.EndMessages();
                return;
            }
            else
            {
                Console.WriteLine("You have won the game!");
            }
        }
    }
}
