using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public int ID;
    public Vector3 Position;
    public List<Edge> edges;
    public bool start;
    public bool end;

    public void Awake()
    {
        Position = transform.position;
        edges = new List<Edge>();

    }
    public Node(int id, Vector3 position)
    {

    }

    public void ConnectedEdge(Edge edge)
    {
        edges.Add(edge);
    }
}
