using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Word { get; set; }
        public string Sentence { get; set;}
        public int WordCounter { get; set; }
        public RepeatCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
            WordCounter = 0;
        }

        public int CountWord()
        {
            string[] splittedSentence = Sentence.Split(' ');
            foreach (string item in splittedSentence)
            {
                if(item == Word)
                {
                    WordCounter++;
                }
            }
            return WordCounter;
        }
    }
}
