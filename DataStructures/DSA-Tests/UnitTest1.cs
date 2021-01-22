using System;
using Xunit;
using LinkedLists;

namespace DataStructures
{
    public class UnitTest1
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
        [Fact]
        public void greaterThanLength()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int k = 10;
            int expected = 9;

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            Assert.Equal(expected, list.kthFromEnd(k));
        }
        [Fact]
        public void sameLengthFromEnd()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int k = 3;
            int expected = 9;

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            Assert.Equal(expected, list.kthFromEnd(k));
        }
        [Fact]
        public void kNegativeTest()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int k = -1;
            int expected = 0;

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            Assert.Equal(expected, list.kthFromEnd(k));
        }
        [Fact]
        public void sizeOf1Test()
        {
            int value = 5;
            int k = 0;
            int expected = 5;

            LinkedList list = new LinkedList();
            list.insert(value);

            Assert.Equal(expected, list.kthFromEnd(k));
        }
        [Fact]
        public void happyPath()
        {
            int value = 5;
            int value2 = 3;
            int value3 = 9;
            int k = 1;
            int expected = 3;

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            Assert.Equal(expected, list.kthFromEnd(k));
        }
        [Fact]
        public void zippListhappyPath()
        {
            int value = 1;
            int value2 = 2;
            int value3 = 3;

            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            string expected = "3 -> 6 -> 2 -> 5 -> 1 -> 4 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            LinkedList list2 = new LinkedList();
            list2.insert(value4);
            list2.insert(value5);
            list2.insert(value6);

            list.zipList(list, list2);

            Assert.Equal(expected, list.toString());
        }
        [Fact]
        public void zipListOf1()
        {
            int value = 1;

            int value4 = 4;

            string expected = "1 -> 4 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);

            LinkedList list2 = new LinkedList();
            list2.insert(value4);

            list.zipList(list, list2);

            Assert.Equal(expected, list.toString());
        }
        [Fact]
        public void unevenLists()
        {
            int value = 1;
            int value2 = 2;
            int value3 = 3;

            int value4 = 4;

            string expected = "3 -> 4 -> 2 -> 1 -> NULL ";

            LinkedList list = new LinkedList();
            list.insert(value);
            list.insert(value2);
            list.insert(value3);

            LinkedList list2 = new LinkedList();
            list2.insert(value4);

            list.zipList(list, list2);

            Assert.Equal(expected, list.toString());
        }
    }
}
