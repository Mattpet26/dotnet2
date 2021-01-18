using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
    public class LinkedListTest
    {
        [Fact]
        public void EmptyList()
        {
            LinkedList newList = new LinkedList();

            Assert.Null(newList.head);
        }
        [Fact]
        public void LinkedListCreatedWithVal()
        {
            int value = 5;
            LinkedList newList = new LinkedList();
            newList.insert(value);

            Assert.Equal(value, newList.head.value);
        }
        [Fact]
        public void InsertLinkedList()
        {
            int value = 5;
            int value2 = 3;
            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);

            Assert.Equal(value2, list.head.value);
        }
        [Fact]
        public void HeadProperlyChanges()
        {
            int value = 5;
            int value2 = 3;
            LinkedList list = new LinkedList();
            list.insert(value2);

            Assert.Equal(value2, list.head.value);
            list.insert(value);
            Assert.Equal(value, list.head.value);

        }
        [Fact]
        public void includesVal()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            Assert.True(list.includes(value));

        }
        [Fact]
        public void DoesNotIncludeVal()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int falseVal = 100;
            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            Assert.False(list.includes(falseVal));

        }
        [Fact]
        public void toStringLL()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            string expected = "9 -> 3 -> 5 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            Assert.Equal(expected, list.toString());
        }
        [Fact]
        public void addToEnd()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int tail = 11;
            string expected = "9 -> 3 -> 5 -> 11 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);
            list.append(tail);


            Assert.Equal(expected, list.toString());
        }
        [Fact]
        public void addMultiToEnd()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int tail = 11;
            int tail2 = 111;
            string expected = "9 -> 3 -> 5 -> 11 -> 111 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);
            list.append(tail);
            list.append(tail2);


            Assert.Equal(expected, list.toString());
        }
        [Fact]
        public void insertNewTail()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int beforeVal = 11;
            string expected = "9 -> 3 -> 5 -> 11 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);
            list.insertAfter(5, beforeVal);


            Assert.Equal(expected, list.toString());
        }
        [Fact]
        public void insertNewHead()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int beforeVal = 11;
            string expected = "11 -> 9 -> 3 -> 5 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);
            list.insertBefore(value3, beforeVal);


            Assert.Equal(expected, list.toString());
        }
        [Fact]
        public void insertMiddleList()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int beforeVal = 11;
            string expected = "9 -> 3 -> 11 -> 5 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);
            list.insertAfter(3, beforeVal);


            Assert.Equal(expected, list.toString());
        }
    }
}
