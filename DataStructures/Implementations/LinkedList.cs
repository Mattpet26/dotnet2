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
        public void append(int value)
        {
            Node current = this.head;
            Node node = new Node(value);

            while(current != null)
            {
                current = current.next;
                if(current.next == null)
                {
                    current.next = node;
                    return;
                }
            }
        }
        public void insertAfter(int value, int newVal)
        {
            Node node = new Node(newVal);
            Node current = this.head;

            while (current != null)
            {
                if(current.value == value)
                {
                    Node tempVar = current.next;
                    current.next = node;
                    node.next = tempVar;
                }
                current = current.next;
            }
        }
        public void insertBefore(int value, int newVal)
        {
            Node node = new Node(newVal);
            Node current = head;

            while (current != null)
            {
                if (current.value == value)
                {
                    insert(newVal);
                }
                current = current.next;
            }
        }
    }
}
