using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinaryTree : Tree
    {
        public BinaryTree(Node root)
        {
            Root = root;
        }
        /// <summary>
        /// Nodes are added top down.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public List<int> PreOrder(Node current, List<int> output)
        {
            if (current != null)
            {
                output.Add(current.Value);
                PreOrder(current.Left, output);
                PreOrder(current.Right, output);
            }
            return output;
        }

        /// <summary>
        /// Nodes are added from left to right
        /// </summary>
        /// <param name="current"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public List<int> InOrder(Node current, List<int> output)
        {
            if (current != null)
            {
                InOrder(current.Left, output);
                output.Add(current.Value);
                InOrder(current.Right, output);
            }
            return output;
        }

        /// <summary>
        /// Nodes are added left, right, then parent.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public List<int> PostOrder(Node current, List<int> output)
        {
            if (current != null)
            {
                PostOrder(current.Left, output);
                PostOrder(current.Right, output);
                output.Add(current.Value);
            }
            return output;
        }

        public int FindMaxVal(Node current)
        {
            if (current == null)
            {
                return 0;
            }
            int maxLeft = FindMaxVal(current.Left);
            int maxRight = FindMaxVal(current.Right);

            if (maxLeft > current.Value)
            {
                current.Value = maxLeft;
            }
            else if (maxRight > current.Value)
            {
                current.Value = maxRight;
            }
            return current.Value;
        }
    }
}
