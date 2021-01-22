using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack
    {
        public Node Top { get; set; }

        public Stack()
        {
            this.Top = null;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            node.next = Top;
            Top = node;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException();
            }
            else
            {
                int output = Top.value;
                Top = Top.next;
                return output;
            }
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException();
            }
            else
            {
                int output = Top.value;
                return output;
            }
        }
    }
}