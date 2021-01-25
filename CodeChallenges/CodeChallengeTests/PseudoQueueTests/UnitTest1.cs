using System;
using Xunit;
using PseudoQueue;
using DataStructures;

namespace PseudoQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueTest()
        {
            PseudoQueu<int> stack1 = new PseudoQueu<int>();

            stack1.Enqueue(15);
            stack1.Enqueue(10);
            int expected = 15;
            int actual = stack1.Dequeue();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MultiDequeue()
        {
            PseudoQueu<int> stack1 = new PseudoQueu<int>();

            stack1.Enqueue(15);
            stack1.Enqueue(10);
            stack1.Dequeue();
            int expected = 10;
            int actual = stack1.Dequeue();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestEmptyDequeue()
        {
            PseudoQueu<int> stack1 = new PseudoQueu<int>();

            Assert.Throws<NullReferenceException>(() => stack1.Dequeue());
        }
    }
}
