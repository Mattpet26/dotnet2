using System;
using System.Collections.Generic;
using Trees;
using Xunit;

namespace TreeIntersectTEST
{
    public class UnitTest1
    {
        static Node makeNewTree1()
        {
            Node one = new Node(11);
            Node two = new Node(22);
            Node three = new Node(33);
            Node four = new Node(44);
            Node five = new Node(55);
            Node six = new Node(66);
            four.Left = two;
            four.Right = five;
            two.Left = one;
            two.Right = three;
            five.Right = six;
            return four;
        }

        static Node makeNewTree2()
        {
            Node one = new Node(11);
            Node two = new Node(22);
            Node three = new Node(3);
            Node four = new Node(44);
            Node five = new Node(5);
            Node six = new Node(66);
            four.Left = two;
            four.Right = five;
            two.Left = one;
            two.Right = three;
            five.Right = six;
            return four;
        }
        static Node makeNewTree3()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            four.Left = two;
            four.Right = five;
            two.Left = one;
            two.Right = three;
            five.Right = six;
            return four;
        }
        [Fact]
        public void TestTreeIntersectHappyPath()
        {
            Node root = makeNewTree1();
            Node root2 = makeNewTree2();
            BinaryTree tree1 = new BinaryTree(root);
            BinaryTree tree2 = new BinaryTree(root2);

            List<int> listOfIntersections = new List<int>();
            listOfIntersections.Add(11);
            listOfIntersections.Add(22);
            listOfIntersections.Add(44);
            listOfIntersections.Add(66);

            Assert.Equal(listOfIntersections, TreeIntersection.TreeIntersection.treeIntersection(tree1, tree2));
        }
        [Fact]
        public void TestNoIntersection()
        {
            Node root = makeNewTree1();
            Node root2 = makeNewTree3();
            BinaryTree tree1 = new BinaryTree(root);
            BinaryTree tree2 = new BinaryTree(root2);

            List<int> listOfIntersections = new List<int>();

            Assert.Equal(listOfIntersections, TreeIntersection.TreeIntersection.treeIntersection(tree1, tree2));
        }
    }
}
