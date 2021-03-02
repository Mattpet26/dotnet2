using Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphSearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Graph graph = new Graph();
            Graph.GraphNode one = graph.addNode(1);
            Graph.GraphNode two = graph.addNode(2);
            Graph.GraphNode three = graph.addNode(3);

            graph.addEdge(one, two, 9);
            graph.addEdge(one, three, 5);
            List<Graph.GraphEdge> oneEdges = graph.getNeighbors(one);
            List<Graph.GraphEdge> twoEdges = graph.getNeighbors(two);

            List<Graph.GraphNode> expectedValue = new List<Graph.GraphNode>();
            expectedValue.Add(one);
            expectedValue.Add(two);
            expectedValue.Add(three);

            Assert.Equal(expectedValue, GraphSearch.BreadthFirst.breadthFirst(one));
        }
    }
}
