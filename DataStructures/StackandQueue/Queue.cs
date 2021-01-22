using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }
        public Queue()
        {
            this.Front = null;
        }
        public bool IsEmpty()
        {
            return Front == null;
        }
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (IsEmpty())
            {
                Back = node;
                Front = node;
            }
            else
            {
                Back.next = node;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException();
            }
            else
            {
                int output = Front.value;
                Front = Front.next;
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
                int output = Front.value;
                return output;
            }
        }
    }
}
