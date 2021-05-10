using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class graph<TValue, TEdge>
    {

        private readonly Dictionary<TValue, Node> nodes = new();
        /*AddNode() Adds a new node to the graph Takes in the value of that node Returns the added node*/
        public void AddNode(TValue value)
        {
            var node = new Node { Value = value };
            nodes.Add(value, node);
        }

        // AddEdge() Adds a new edge between two nodes in the graph Include the ability to have a “weight”
        // Takes in the two nodes to be connected by the edge Both nodes should already be in the Graph
        public void AddEdge(TValue from, TValue to, TEdge data = default)
        {
            var fromNode = nodes[from];
            var toNode = nodes[to];

            fromNode.Edges.Add(new Edge
            {
                From = fromNode,
                To = toNode,
            });
        }

        // GetNodes() Returns all of the nodes in the graph as a collection(set, list, or similar)
        public IEnumerable<Node> Nodes => nodes.Values;



        // GetNeighbors() Returns a collection of edges connected to the given node
        // Takes in a given node Include the weight of the connection in the returned collection
        public IEnumerable<Edge> GetNeighbors(TValue value)
        {
            var fromNode = nodes[value];

            return fromNode.Edges;
        }

        // Size() Returns the total number of nodes in the graph
        public int Count => nodes.Count;

        public class Node
        {
            public TValue Value { get; set; }
            public List<Edge> Edges { get; } = new List<Edge>();
        }

        public class Edge
        {
            public Node From { get; set; }
            public Node To { get; set; }
        }
    }
}
