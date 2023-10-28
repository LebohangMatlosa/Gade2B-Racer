using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointStack : MonoBehaviour
{
    public Stack<TimerCheckpoints> checkpointStack = new Stack<TimerCheckpoints>();
    public Queue<TimerCheckpoints> checkpointQueue = new Queue<TimerCheckpoints>();

    public timer timerController;

    public void AddCheckpoint(TimerCheckpoints checkpoint)
    {
        checkpointStack.Push(checkpoint);
        checkpointQueue.Enqueue(checkpoint);
    }

    public void passCheckpoint()
    {
        if (checkpointStack.Count>0)
        {
            TimerCheckpoints checkpoint = checkpointStack.Pop();
            timerController.IncreaseTimer(checkpoint.timeIncrease);
        }

        if (checkpointQueue.Count>0)
        {
            TimerCheckpoints nextCheckpoint = checkpointQueue.Peek();
        }
    }
}
