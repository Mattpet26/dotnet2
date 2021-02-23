using System;
using System.Collections.Generic;
using System.Text;
using Trees;

namespace TreeIntersection
{
    public class TreeIntersection
    {
        public static List<int> treeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            HashSet<int> comparisonHash = new HashSet<int>();
            List<int> setOfVal1 = tree1.InOrder(tree1.Root, new List<int>());
            List<int> setOfVal2 = tree2.InOrder(tree2.Root, new List<int>());

            List<int> listOfIntersections = new List<int>();
            foreach(int i in setOfVal1)
            {
                comparisonHash.Add(i);
            }
            foreach(int j in setOfVal2)
            {
                if (comparisonHash.Contains(j))
                {
                    listOfIntersections.Add(j);
                }
            }
            return listOfIntersections;
        }
    }
}
