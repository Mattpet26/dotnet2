using Graphs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphSearch
{
    public class BreadthFirst
    {
        public static List<Graph.GraphNode> breadthFirst(Graph.GraphNode node)
        {
            List<Graph.GraphNode> resultArr = new List<Graph.GraphNode>();
            List<Graph.GraphNode> currentNode = new List<Graph.GraphNode>();
            Queue<Graph.GraphNode> queue = new Queue<Graph.GraphNode>();

            currentNode.Add(node);
            queue.Enqueue(node);

            while (queue.Count != 0)
            {
                Graph.GraphNode temp = queue.Dequeue();
                foreach (Graph.GraphEdge edge in temp.edgeList)
                {
                    Graph.GraphNode neighbor = edge.node;
                    currentNode.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
                resultArr.Add(temp);
            }
            return resultArr;
        }
    }
}
