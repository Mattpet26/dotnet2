using System;
using DataStructures;

namespace PseudoQueue
{
    public class PseudoQueu<T>
    {
        Stack<T> stack1 { get; set; }

        public PseudoQueu()
        {
            stack1 = new Stack<T>();
        }
        public T Dequeue()
        {
            Stack<T> temp = new Stack<T>();
            while (!stack1.IsEmpty())
            {
                temp.Push(stack1.Pop());
            }
            T result = temp.Pop();
            while (!temp.IsEmpty())
            {
                stack1.Push(temp.Pop());
            }
            return result;
        }
        public void Enqueue(T value)
        {
            stack1.Push(value);
        }
    }
}
