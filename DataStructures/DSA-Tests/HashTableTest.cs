using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures;

namespace DSA_Tests
{
    public class HashTableTest
    {
        [Fact]
        public void TestAllMethodsHashTable()
        {
            Hashtable table = new Hashtable(50);
            table.Add("Lee", "Jones");
            table.Add("Laa", "Jimmy");
            table.Add("Lii", "Jack");
            table.Add("Luu", "John");
            table.Add("Loo", "Jackson");
            table.Add("Lyy", "Jabba");
            string actual = table.Get("Lyy");
            string expected = "Lyy";

            Assert.Equal(expected, actual);
            Assert.True(table.Contains("Lyy"));
        }
    }
}
