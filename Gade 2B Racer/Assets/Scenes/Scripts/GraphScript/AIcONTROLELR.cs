using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIcONTROLELR : MonoBehaviour
{
    
    public Graph graph;
    public Transform destination;
    private List<Node> waypoints = new List<Node>();
    private int currentWayPointIndex = 0;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Node[] nodes = FindObjectOfType<Node>();
        graph = new Graph();
        graph.Nodes.Clear();
        graph.Nodes.AddRange(nodes);

        new Edge(findMe(2), findMe(1), 0);
        new Edge(findMe(2), findMe(3), 0);
        new Edge(findMe(3), findMe(4), 0);
        new Edge(findMe(1), findMe(4), 0);
        new Edge(findMe(4), findMe(0), 0);
        CalculatePathToDestination();
        

    }
     void CalculatePathToDestination()
    {
        Node startNode = null;
        Node endNode = null;
        Node[]nodes = FindObjectOfType<Node>();

        foreach(Node node in nodes)
        {
            if (node.start)
            {
                startNode = node;
            }
            if (node.end)
            {
                endNode = node;
            }

        }
        if (startNode != null && endNode != null)
        {
            waypoints = CalculatePath(startNode, endNode);
            currentWayPointIndex = 0;
        }
        List<Node> CalculatePath(Node start, Node end)
        {
            List<Node> path = new List<Node>();

            path.Add(start);
            while (true)
            {
                if (path[path.Count-1] == end)
                {
                    break;
                }

                List<Node> possibilities = new List<Node>();
                foreach(Edge possible in path[path.Count - 1].edges)
                {
                    if (possible.NodeB == path[path.Count - 1])
                    {
                        continue;
                    }
                    if (path.Contains(possible.NodeB) && path.Contains(possible.NodeA))
                    {
                        continue;
                    }
                    else
                    {
                        possibilities.Add(possible.NodeA);
                    }
                }
                int randomIndex = Random.Range(0, possibilities.Count);
                Debug.Log(randomIndex);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
