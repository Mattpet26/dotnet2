using Graphs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphSearch
{
    public class DepthFirst
    {
        public static List<Graph.GraphNode> DFS(Graph.GraphNode start)
        {
            Stack<Graph.GraphNode> Stack = new Stack<Graph.GraphNode>();
            HashSet<Graph.GraphNode> Seen = new HashSet<Graph.GraphNode>();
            List<Graph.GraphNode> result = new List<Graph.GraphNode>();

            Stack.Push(start);

            while (Stack.Count != 0)
            {
                Graph.GraphNode current = Stack.Pop();
                if (!Seen.Contains(current))
                {
                    Seen.Add(current);
                }
                foreach (Graph.GraphNode adjacent in Stack)
                {
                    if (!Seen.Contains(adjacent))
                    {
                        Stack.Push(adjacent);
                    }
                }
                result.Add(current);
            }
            return result;
        }
    }
}
