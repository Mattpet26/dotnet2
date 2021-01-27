using System;
using Xunit;
using MultiBracketValidation;

namespace MultiBracketTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestTrueValidation()
        {
            string input = "{}";
            Assert.True(MultiBracket.MultiBracketValid(input));
        }
        [Fact]
        public void TestFalseBracketResult()
        {
            string input = "{abc[}";
            Assert.False(MultiBracket.MultiBracketValid(input));
        }
        [Fact]
        public void TestLotsOfBrackets()
        {
            string input = "{[[[]]]}()(())";
            Assert.True(MultiBracket.MultiBracketValid(input));
        }
        [Fact]
        public void TestSingleBrackets()
        {
            string input = "{[(]}";
            Assert.False(MultiBracket.MultiBracketValid(input));
        }
    }
}
