using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListScript : MonoBehaviour
{
    private LinkedList<Checkpoints> checkpoints = new LinkedList<Checkpoints>();
    private LinkedListNode<Checkpoints> currentCheckpoints;

    public void CreateCheckpoints(Vector3 position)
    {
        int checkpointID = checkpoints.Count + 1;
        Checkpoints checkpoint = new Checkpoints(position, checkpointID);
        checkpoints.AddLast(checkpoint);
    }

    public void SetStartChecpoint()
    {
        if (checkpoints.First != null)
        {
            currentCheckpoints = checkpoints.First;
        }
    }

    public Vector3 getTheNextCheckpoint()
    {
        if (currentCheckpoints != null)
        {
            LinkedListNode<Checkpoints> next = currentCheckpoints.Next;
            if (next == null)
            {
                next = checkpoints.First;
            }
            currentCheckpoints = next;
            return next.Value.checkpointPosition.position;
        }
        return Vector3.zero;
    }
    
}
