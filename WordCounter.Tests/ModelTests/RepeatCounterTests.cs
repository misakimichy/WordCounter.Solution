using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void CountWord_ReturnWordCounter_1()
        {
            RepeatCounter testCounter = new RepeatCounter("big", "I want to eat a big donut.");
            int result = testCounter.CountWord();
            Assert.AreEqual(1, result);
        }
 
    }
}