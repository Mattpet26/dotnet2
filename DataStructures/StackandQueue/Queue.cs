using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Back { get; set; }
        public Queue()
        {
            this.Front = null;
        }
        public bool IsEmpty()
        {
            return Front == null;
        }
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
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
        public T Dequeue()
        {
            if (Front == null)
            {
                throw new NullReferenceException();
            }
            else if(Front.next == null)
            {
                T output = Front.value;
                Front = null;
                Back = Front;
                return output;
            }
            else
            {
                T output = Front.value;
                Front = Front.next;
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
                T output = Front.value;
                return output;
            }
        }
    }
}
