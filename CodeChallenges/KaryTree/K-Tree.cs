using System;
using System.Collections.Generic;
using System.Text;

namespace KaryTree
{
    public class K_Tree<T>
    {
        Node<T> root;
        public class Node<T>
        {
            public List<Node<T>> children;
            public T value;

            public Node(T value)
            {
                this.value = value;
            }
        }
        public void insert(T value)
        {
            if (root == null)
            {
                root = new Node<T>(value);
                return;
            }
            insert(root, value);
        }

        private void insert(Node<T> current, T value)
        {
            //int a = (int)Math.Floor(Math.random() * (current.children.Count + 1));
            //if (current.children.Count == 0 || a == current.children.Count)
            //{
                //current.children.Add(new Node<T>(value));
                //return;
            //}
            //Console.WriteLine(a);
            //insert(current.children.Find(a), value);
        }
        public K_Tree<T> fizzBuzz()
        {
            K_Tree<T> newTree = new K_Tree<T>();
            //newTree.root = fizzBuzz(this.root);
            return newTree;
        }
    }
}

