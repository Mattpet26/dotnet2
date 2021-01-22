using System;
using Xunit;
using DataStructures;
using StackandQueue;

namespace DSA_Tests
{
    public class StackandQueueTest
    {
        [Fact]
        public void pushStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);

            int expected = 5;
            int actual = stack.Top.value;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void pushStackMulti()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            int expected = 15;
            int actual = stack.Top.value;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void popStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            int expected = 15;
            int actual = stack.Pop();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void popAllValues()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.True(stack.IsEmpty());
        }
        [Fact]
        public void peekNextVal()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            int expected = 10;
            stack.Pop();

            Assert.Equal(expected, stack.Peek());
        }
        [Fact]
        public void EmptyStack()
        {
            Stack<int> stack = new Stack<int>();
            Assert.True(stack.IsEmpty());
        }
        [Fact]
        public void StackThrowException()
        {
            Stack<int> stack = new Stack<int>();

            Assert.Throws<NullReferenceException>(() => stack.Top.value);
        }
        [Fact]
        public void EnqueueWorks()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            int expected = 5;

            Assert.Equal(expected, que.Peek());
        }
        [Fact]
        public void EnqueueMultiValue()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            que.Enqueue(52);
            que.Enqueue(1);
            int expected = 5;

            Assert.Equal(expected, que.Peek());
        }
        [Fact]
        public void Dequeue()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            que.Enqueue(52);
            que.Enqueue(1);
            int expected = 5;

            Assert.Equal(expected, que.Dequeue());
        }
        [Fact]
        public void PeekWorking()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            que.Enqueue(52);
            que.Enqueue(1);
            int expected = 5;

            Assert.Equal(expected, que.Peek());
        }
        [Fact]
        public void DequeueEmpty()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            que.Enqueue(52);

            que.Dequeue();
            que.Dequeue();

            Assert.True(que.IsEmpty());
        }
        [Fact]
        public void EmptyQueue()
        {
            Queue<int> que = new Queue<int>();

            Assert.True(que.IsEmpty());
        }
        [Fact]
        public void ThrowQueuException()
        {
            Queue<int> que = new Queue<int>();
            Assert.Throws<NullReferenceException>(() => que.Front.value);
        }
    }
}
