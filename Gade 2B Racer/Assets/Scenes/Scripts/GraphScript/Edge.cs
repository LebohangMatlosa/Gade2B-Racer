using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{
    public Node NodeA;
    public Node NodeB;
    public Node NodeC;
    public Node NodeD;
    public Node NodeE;
    public Node NodeF;
    public Node NodeG;
    public float Cost;

    public Edge(Node nodeA, Node nodeB, Node nodeC, Node nodeD, Node nodeE, Node nodeF, Node nodeG, float cost)
    {
        NodeA = nodeA;
        NodeB = nodeB;
        NodeC = nodeC;
        NodeD = nodeD;
        NodeE = nodeE;
        NodeF = nodeF;
        NodeG = nodeG;
        Cost = cost;

        nodeA.ConnectedEdge(this);
        nodeB.ConnectedEdge(this);
        nodeC.ConnectedEdge(this);
        nodeD.ConnectedEdge(this);
        nodeE.ConnectedEdge(this);
        nodeF.ConnectedEdge(this);
        nodeG.ConnectedEdge(this);
    }
}
