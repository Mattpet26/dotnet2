using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Traverse tree recursively, to find where node belongs.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node AddRecursively(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }
            if (value < current.Value)
            {
                current.Left = AddRecursively(current.Left, value);
            }
            else if (value > current.Value)
            {
                current.Right = AddRecursively(current.Right, value);
            }
            else
            {
                return current;
            }
            return current;
        }
        public void add(int value)
        {
            Root = AddRecursively(Root, value);
        }


        public bool Find(int id)
        {
            Node current = Root;
            while (current != null)
            {
                if (current.Value == id)
                {
                    return true;
                }
                else if (current.Value > id)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }
    }
}
