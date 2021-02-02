using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Trees;

namespace DSA_Tests
{
    public class BinaryTreeTests
    {
        //here we make a tree for testing purposes so we don't have to make one each test.
        static Node makeNewTree()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            two.Left = one;
            two.Right = three;
            return two;
        }

        [Fact]
        public void TestEmptyTree()
        {
            Tree emptyTree = new Tree();

            Assert.NotNull(emptyTree);
        }
        [Fact]
        public void TestOneNodeTree()
        {
            Tree tree = new Tree(new Node(1));
            int expected = 1;

            Assert.Equal(expected, tree.Root.Value);
        }
        [Fact]
        public void TestAddLeftandRight()
        {
            Tree tree = new Tree(new Node(1));
            Node four = new Node(4);
            Node three = new Node(3);
            tree.Root.Left = four;
            tree.Root.Right = three;

            int expected = 3;

            Assert.Equal(expected, tree.Root.Right.Value);
        }
        [Fact]
        public void TestPreOrderTraversal()
        {
            Node root = makeNewTree();
            BinaryTree tree = new BinaryTree(root);

            List<int> expected = new List<int> { 2, 1, 3};
            Assert.Equal(expected, tree.PreOrder(tree.Root, new List<int>()));
        }
        [Fact]
        public void TestInOrderTraversal()
        {
            Node root = makeNewTree();
            BinaryTree tree = new BinaryTree(root);

            List<int> expected = new List<int> { 1, 2, 3 };
            Assert.Equal(expected, tree.InOrder(tree.Root, new List<int>()));
        }
        [Fact]
        public void TestPostOrderTraversal()
        {
            Node root = makeNewTree();
            BinaryTree tree = new BinaryTree(root);

            List<int> expected = new List<int> { 1, 3, 2 };
            Assert.Equal(expected, tree.PostOrder(tree.Root, new List<int>()));
        }
        [Fact]
        public void testMaxVal()
        {
            Node root = makeNewTree();
            BinaryTree tree = new BinaryTree(root);

            int expected = 3;
            Assert.Equal(expected, tree.FindMaxVal(root));
        }
        [Fact]
        public void testMaxValEmptyTree()
        {
            Node root = new Node();
            BinaryTree bt = new BinaryTree(root);
            int expected = 0;

            Assert.Equal(expected, bt.FindMaxVal(root));
        }
    }
}
