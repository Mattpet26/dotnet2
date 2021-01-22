using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        public Stack()
        {
            this.Top = null;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.next = Top;
            Top = node;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException();
            }
            else
            {
                T output = Top.value;
                Top = Top.next;
                return output;
            }
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException();
            }
            else
            {
                T output = Top.value;
                return output;
            }
        }
    }
}