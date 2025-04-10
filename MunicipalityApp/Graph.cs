using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class Graph
    {
        // Dictionary to store the adjacency list of the graph
        public Dictionary<int, List<int>> AdjacencyList { get; } = new Dictionary<int, List<int>>();

        // Method to add a node to the graph
        public void AddNode(int nodeId)
        {
            // Check if the node already exists in the graph
            if (!AdjacencyList.ContainsKey(nodeId))
            {
                // If not, add the node with an empty list of neighbors
                AdjacencyList[nodeId] = new List<int>();
            }
        }

        // Method to add an edge between two nodes in the graph
        public void AddEdge(int fromNode, int toNode)
        {
            // Ensure both nodes exist in the graph
            if (!AdjacencyList.ContainsKey(fromNode)) AddNode(fromNode);
            if (!AdjacencyList.ContainsKey(toNode)) AddNode(toNode);

            // Add the edge from fromNode to toNode
            AdjacencyList[fromNode].Add(toNode);
        }

        // Method to get the neighbors of a given node
        public List<int> GetNeighbors(int nodeId)
        {
            // Return the list of neighbors if the node exists, otherwise return an empty list
            return AdjacencyList.ContainsKey(nodeId) ? AdjacencyList[nodeId] : new List<int>();
        }
    }

}
