using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{
    public Node NodeA;
    public Node NodeB;
    public float Cost;

    public Edge(Node nodeA, Node nodeB, float cost)
    {
        NodeA = nodeA;
        NodeB = nodeB;
        Cost = cost;

        nodeA.ConnectedEdge(this);
        nodeB.ConnectedEdge(this);
    }
}
