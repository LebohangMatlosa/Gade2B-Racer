using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public List<Node> Nodes { get; set; } 
    public List<Edge> Edges { get; set; }
    
    public Graph()
    {
        Nodes = new List<Node>();
        Edges = new List<Edge>();
    }

    public void AddNode(Node node)
    {
        Nodes.Add(node);
    }

    public void AddEdge(Node nodeA, Node nodeB, float cost)
    {
        Edges.Add(new Edge(nodeA, nodeB, cost));
        Edges.Add(new Edge(nodeB, nodeB, cost));
    }
}
