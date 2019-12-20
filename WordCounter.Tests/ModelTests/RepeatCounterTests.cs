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
        [TestMethod]
        public void CountWord_WordCounterIncrementsWhenWordIsRepeated_3()
        {
            RepeatCounter testCounter = new RepeatCounter("big", "I want to eat a big donut and a big cookie at a big cafe.");
            int result = testCounter.CountWord();
            Assert.AreEqual(3, result);
        }
        
        [TestMethod]
        public void CheckValidInput_CheckWordInputIsString_True()
        {
            bool result = RepeatCounter.CheckValidInput("big");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckValidInput_CheckSentenceInputIsString_True()
        {
            bool result = RepeatCounter.CheckValidInput("I want to eat a big donut.");
            Assert.AreEqual(true, result);
        }
    }
}