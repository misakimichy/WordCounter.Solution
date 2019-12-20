using System;

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
            if(Sentence.Contains(Word))
            {
                WordCounter++;
            }
            return WordCounter;
        }
    }
}