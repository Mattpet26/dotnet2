using Graphs;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA_Tests
{
    public class GraphTests
    {
        [Fact]
        public void TestGraph()
        {
            Graph graph = new Graph();
            graph.addNode(1);
            Assert.NotNull(graph.getNodes());
        }
        [Fact]
        public void testAddEdge()
        {
            Graph graph = new Graph();
            Graph.GraphNode node = graph.addNode(1);
            Graph.GraphNode node2 = graph.addNode(2);
            graph.addEdge(node, node2, 3);
            List<Graph.GraphEdge> oneEdges = graph.getNeighbors(node);

            Assert.Equal(2, graph.Size());
            Assert.Equal(oneEdges, node.edgeList);
        }
        [Fact]
        public void testGetNeighbor()
        {
            Graph graph = new Graph();
            Graph.GraphNode one = graph.addNode(1);
            Graph.GraphNode two = graph.addNode(2);
            Graph.GraphNode three = graph.addNode(3);

            graph.addEdge(one, two, 9);
            graph.addEdge(one, three, 5);
            List<Graph.GraphEdge> oneEdges = graph.getNeighbors(one);
            List<Graph.GraphEdge> twoEdges = graph.getNeighbors(two);

            HashSet<Graph.GraphNode> nodeDestinations = new HashSet<Graph.GraphNode>();
            foreach(Graph.GraphEdge edge in oneEdges) nodeDestinations.Add(edge.node);

            Assert.True(nodeDestinations.Contains(two));
            Assert.True(nodeDestinations.Contains(three));
        }
        [Fact]
        public void testGetWeight()
        {
            Graph graph = new Graph();
            Graph.GraphNode one = graph.addNode(1);
            Graph.GraphNode two = graph.addNode(2);
            Graph.GraphNode three = graph.addNode(3);

            graph.addEdge(one, two, 9);
            foreach(Graph.GraphEdge edges in one.edgeList)
            {
                Assert.Equal(9, edges.weight);
            }
        }
        [Fact]
        public void testGetSize()
        {
            Graph graph = new Graph();
            graph.addNode(1);
            Assert.Equal(1, graph.Size());
            graph.addNode(2);
            Assert.Equal(2, graph.Size());

        }
    }
    
}
