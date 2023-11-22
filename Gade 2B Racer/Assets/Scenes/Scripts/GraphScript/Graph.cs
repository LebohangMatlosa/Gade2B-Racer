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

    public void AddEdge(Node nodeA, Node nodeB, Node nodeC, Node nodeD, Node nodeE, Node nodeF, Node nodeG, float cost)
    {
        Edges.Add(new Edge(nodeA, nodeB,nodeC, nodeD, nodeE,  nodeF,  nodeG, cost));
        Edges.Add(new Edge(nodeB, nodeB,nodeC, nodeD, nodeE, nodeF, nodeG, cost));
    }
}
