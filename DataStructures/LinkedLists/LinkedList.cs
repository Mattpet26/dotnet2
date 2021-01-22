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

            while (current != null)
            {
                if (current.value == target)
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

            while (current != null)
            {
                current = current.next;
                if (current.next == null)
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
                if (current.value == value)
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
        public int kthFromEnd(int number)
        {
            Node current = this.head;
            Node first = current;
            Node second = current;
            int counter = 0;

            if (number > 0)
            {
                for (int i = 0; i < number + 1; i++)
                {
                    first = first.next;
                    //this if statement checks if the length of linkedlist == k, if so, just return the head.
                    if (first == null)
                    {
                        return second.value;
                    }
                    counter++;
                }

                while (first != null)
                {
                    first = first.next;
                    second = second.next;
                    counter++;
                }
                return second.value;
            }
            else if (number < 0)
            {
                //this way if the number entered is less than 0, we don't run into problems
                //but if they enter in 0, it will just return the last number in the list.
                return 0;
            }
            else
            {
                return second.value;
            }
        }
        public LinkedList zipList(LinkedList list1, LinkedList list2)
        {
            Node head1 = list1.head;
            Node head2 = list2.head;
            Node temp1 = head1.next;
            Node temp2 = head2.next;

            if (head1 == null && head2 == null)
            {
                throw new NullReferenceException("Both lists are empty");
            }
            if (head1 == null)
            {
                return list2;
            }
            else if (head2 == null)
            {
                return list1;
            }

            while (temp1 != null && temp2 != null)
            {
                head1.next = head2;
                head2.next = temp1;
                head1 = temp1;
                head2 = temp2;
                temp1 = temp1.next;
                temp2 = temp2.next;
            }
            head1.next = head2;
            if (temp1 != null && temp2 == null)
            {
                head2.next = temp1;
            }
            return list1;
        }
    }
}
