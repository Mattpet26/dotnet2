using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        public Node head { get; set; }

        public LinkedList()
        {

        }
        public void insert(int value)
        {
            Node node = new Node(value);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }

        }
        public bool includes(int target)
        {
            bool result = false;
            Node current = this.head;

            while(current != null)
            {
                if(current.value == target)
                {
                    result = true;
                }
                current = current.next;
            }

            return result;
        }
        public string toString()
        {
            String result = "";
            Node current = this.head;
            while (current != null)
            {
                result += current.value;
                if (current.next != null)
                {
                    result += " -> ";
                }
                else
                {
                    result += " -> NULL ";
                }
                current = current.next;
            }
            return result;
        }
    }
}
