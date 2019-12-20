using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the Word Counter! \nPlease input a word and a sentence, and we will count how many of the word is used in the sentence.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            string word = TakeWordInput();
            string sentence = TakeSentenceInput();
            RepeatCounter userCounter = new RepeatCounter(word, sentence);
            Console.ForegroundColor = ConsoleColor.Magenta;
            int result = userCounter.CountWord();
            if(result == 0)
            {
                Console.WriteLine("There was no match in the sentence.");
            }
            else if (result == 1)
            {
                Console.WriteLine($"The word is used {result} time in the sentence.");
            }
            else
            {
                Console.WriteLine($"The word is used {result} times in the sentence.");
            }
            Console.ResetColor();
            RepeatGame();
        }

        // Make both user input lower case and trim the white space in the end.
        private static string TakeWordInput()
        {
            Console.WriteLine("\nPlease enter a word:");
            string wordInput = Console.ReadLine().ToLower().Trim();
            bool isValid = RepeatCounter.CheckValidInput(wordInput);
            if(!isValid)
            {
                ErrorMessage();
                TakeWordInput();
            }
            return wordInput;
        }

        private static string TakeSentenceInput()
        {
            Console.WriteLine("\nPlease enter a sentence:");
            string sentenceInput = Console.ReadLine().ToLower().Trim();
            bool isValid = RepeatCounter.CheckValidInput(sentenceInput);
            if(!isValid)
            {
                ErrorMessage();
                TakeSentenceInput();
            }
            return sentenceInput;
        }

        private static void RepeatGame()
        {
            Console.WriteLine("\nDo you want to play again? (Yes / No)");
            string userInput = Console.ReadLine().ToLower().Trim();
            bool isValid = RepeatCounter.CheckValidInput(userInput);
            if(!isValid || (userInput != "yes" && userInput != "no"))
            {
                ErrorMessage();
                RepeatGame();
            }
            else if (userInput == "yes")
            {
                Main();
            }
            else
            {
                Console.WriteLine("See you next time!");
            }
        }

        private static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input!\n");
            Console.ResetColor();
        }
    }
}