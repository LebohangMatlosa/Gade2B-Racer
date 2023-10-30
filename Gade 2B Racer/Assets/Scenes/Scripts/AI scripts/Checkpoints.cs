using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Transform checkpointPosition;
    public Checkpoints nextCheckpoint;
    public Checkpoints previousCheckpoint;
    private Vector3 position;
    private int checkpointID;

    public Checkpoints(Vector3 position, int checkpointID)
    {
        this.position = position;
        this.checkpointID = checkpointID;
    }
}
