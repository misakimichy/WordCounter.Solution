using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class Program
    {
        static void Main()
        {
            string word = TakeWordInput();
            string sentence = TakeSentenceInput();
            RepeatCounter userCounter = new RepeatCounter(word, sentence);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n{userCounter.CountWord()}");
            Console.ResetColor();
            Main();
        }

        private static string TakeWordInput()
        {
            Console.WriteLine("\nPlease enter a word:");
            string wordInput = Console.ReadLine().ToLower();
            bool isWordInputValid = RepeatCounter.CheckValidInput(wordInput);
            if(!isWordInputValid)
            {
                ErrorMessage();
                TakeWordInput();
            }
            return wordInput;
        }

        private static string TakeSentenceInput()
        {
            Console.WriteLine("\nPlease enter a sentence:");
            string sentenceInput = Console.ReadLine().ToLower();
            bool isSentenceInputValid = RepeatCounter.CheckValidInput(sentenceInput);
            if(!isSentenceInputValid)
            {
                ErrorMessage();
                TakeSentenceInput();
            }
            return sentenceInput;
        }

        private static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input!\n");
            Console.ResetColor();
        }
    }
}