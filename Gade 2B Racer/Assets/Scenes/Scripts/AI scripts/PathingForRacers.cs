using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PathingForRacers : MonoBehaviour
{
    public Transform[] PathCheckpoints;
    public int currentCheckpointIndex = 0;
    private NavMeshAgent CarAgent;


    public void Start()
    {
        CarAgent = GetComponent<NavMeshAgent>();
        SetDestinationToNewCheckpoints();
    }
    // Update is called once per frame
    void Update()
    {
        if (CarAgent.remainingDistance < 0.1f)
        {
            currentCheckpointIndex++;
            if (currentCheckpointIndex < PathCheckpoints.Length)
            {
                SetDestinationToNewCheckpoints();
            }
        } 
    }

    public void SetDestinationToNewCheckpoints()
    {
        if (currentCheckpointIndex < PathCheckpoints.Length)
        {
            CarAgent.SetDestination(PathCheckpoints[currentCheckpointIndex].position);
        }
    }
}
