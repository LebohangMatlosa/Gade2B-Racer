using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointTrigger : MonoBehaviour 
{
    CheckPointStack checkpointStack;
    
    public void Start()
    {
        checkpointStack = FindObjectOfType<CheckPointStack>();
    }
    public void OntriggerEnter(Collider coll)
    {
        if (coll.name == "Police car")
        {
            checkpointStack.checkpointStack.Pop();
            checkpointStack.IncreaseTimer(5.0f);
            
        }

        /*if (checkpointQueue.Count>0)
        {
            TimerCheckpoints nextCheckpoint = checkpointQueue.Peek();
        }*/
    }
}
