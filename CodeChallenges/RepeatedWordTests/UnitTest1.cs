using System;
using Xunit;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRepeatedWord()
        {
            string word = "The dog and the cat went to the park with all the other dog and cats. This is a string for an assignment";
            string expected = "the";
            Assert.Equal(expected, RepeatedWord.RepeatedWord.RepeatableWord(word));
        }
        [Fact]
        public void TestWithNoRepeats()
        {
            string word = "The dog and my cat are friends";
            string expected = null;
            Assert.Equal(expected, RepeatedWord.RepeatedWord.RepeatableWord(word));
        }
        [Fact]
        public void TestWithNull()
        {
            string word = "";
            string expected = null;
            Assert.Equal(expected, RepeatedWord.RepeatedWord.RepeatableWord(word));
        }
    }
}
