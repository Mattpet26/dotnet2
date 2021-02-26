using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        public List<GraphNode> nodes;

    public Graph(){
        nodes = new List<GraphNode>();
    }

    public GraphNode addNode(int value){
        GraphNode node = new GraphNode(value);
        nodes.Add(node);
        return node;
    }
    public void addEdge(GraphNode source, GraphNode destination, int weight)
        {
        if(!nodes.Contains(source) || !nodes.Contains(destination)){
            throw new Exception("Neither node was found in the graph, sorry");
        }
        GraphEdge edge = new GraphEdge(weight, destination);

        if(source.edgeList == null){
            source.edgeList = new List<GraphEdge>();
        }
        source.edgeList.Add(edge);
    }
    public List<GraphNode> getNodes(){
        return nodes;
    }
    public List<GraphEdge> getNeighbors(GraphNode node){
        return node.edgeList;
    }
    public int Size(){
        return nodes.Count;
    }



    public class GraphNode{
        public int value;
        public List<GraphEdge> edgeList = new List<GraphEdge>();

        public GraphNode(int value){
            this.value = value;
        }
    }



    public class GraphEdge {
        public int weight;
        public GraphNode node;

        public GraphEdge(int weight, GraphNode node) {
            this.weight = weight;
            this.node = node;
        }
    }
    }
}
