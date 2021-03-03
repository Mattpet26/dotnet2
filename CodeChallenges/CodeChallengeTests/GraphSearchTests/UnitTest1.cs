using Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphSearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBreadthFirst()
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
        [Fact]
        public void TestDepthFirst()
        {
            Graph graph = new Graph();
            Graph.GraphNode one = graph.addNode(1);
            Graph.GraphNode two = graph.addNode(2);
            Graph.GraphNode three = graph.addNode(3);
            Graph.GraphNode four = graph.addNode(4);
            Graph.GraphNode five = graph.addNode(5);
            Graph.GraphNode six = graph.addNode(6);

            graph.addEdge(one, two, 9);
            graph.addEdge(one, three, 5);
            graph.addEdge(three, four, 1);
            graph.addEdge(three, five, 1);
            graph.addEdge(five, six, 1);
            List<Graph.GraphEdge> oneEdges = graph.getNeighbors(one);
            List<Graph.GraphEdge> twoEdges = graph.getNeighbors(two);

            Stack<Graph.GraphNode> expected = new Stack<Graph.GraphNode>();
            expected.Push(one);
            expected.Push(two);
            expected.Push(three);
            expected.Push(five);
            expected.Push(six);
            expected.Push(four);

            Assert.Equal(expected, GraphSearch.DepthFirst.DFS(one));
        }
    }
}
