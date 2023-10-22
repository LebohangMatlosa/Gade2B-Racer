using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Vector3 position;
    public int checkpointID;

    public Checkpoints(Vector3 position, int checkpointID)
    {
        this.position = position;
        this.checkpointID = checkpointID;
    }
}
