using System;
using System.Collections.Generic;
using Xunit;

namespace LeftJoinTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestJoinFunctional()
        {
            Dictionary<string, string> synonyms = new Dictionary<string, string>();
            synonyms.Add("fond", "enamored");
            synonyms.Add("wrath", "anger");
            synonyms.Add("diligent", "employed");

            Dictionary<string, string> antonyms = new Dictionary<string, string>();
            antonyms.Add("fond", "averse");
            antonyms.Add("wrath", "delight");
            antonyms.Add("diligent", "nani");

            List<string> list = new List<string>();
            list.Add("fond: enamored, averse");
            list.Add("wrath: anger, delight");
            list.Add("diligent: employed, nani");

            Assert.Equal(list, LeftJoin.LeftJoin.leftJoin(synonyms, antonyms));
        }
        [Fact]
        public void TestWithNullValues()
        {
            Dictionary<string, string> synonyms = new Dictionary<string, string>();
            synonyms.Add("fond", "enamored");
            synonyms.Add("wrath", "anger");
            synonyms.Add("diligent", "employed");

            Dictionary<string, string> antonyms = new Dictionary<string, string>();
            antonyms.Add("aa", "averse");
            antonyms.Add("bb", "delight");
            antonyms.Add("cc", "nani");

            List<string> list = new List<string>();
            list.Add("fond: enamored, null");
            list.Add("wrath: anger, null");
            list.Add("diligent: employed, null");

            Assert.Equal(list, LeftJoin.LeftJoin.leftJoin(synonyms, antonyms));
        }
    }
}
