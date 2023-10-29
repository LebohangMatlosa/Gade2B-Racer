using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointStack : MonoBehaviour
{
    public GameObject[] checkpoints;
    public GameObject blob;
    public float racetimer = 60.0f;
    public Stack<GameObject> checkpointStack = new Stack<GameObject>();
    //public Queue<TimerCheckpoints> checkpointQueue = new Queue<TimerCheckpoints>();

    public timer timerController;

    public void AddCheckpoint(GameObject checkpoint)
    {
        foreach (GameObject CheckPoint in checkpoints)
        {
            checkpointStack.Push(checkpoint);
        }

        //checkpointQueue.Enqueue(checkpoint);
    }

    public void OntriggerEnter(Collider coll)
    {
        if (coll.name == "Police car")
        {
            checkpointStack.Pop();
            IncreaseTimer(5.0f);
        }

        /*if (checkpointQueue.Count>0)
        {
            TimerCheckpoints nextCheckpoint = checkpointQueue.Peek();
        }*/
    }
    

    public void IncreaseTimer(float amount)
    {
        racetimer += amount;
    }
}
