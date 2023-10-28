using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCheckpoints : MonoBehaviour
{
    public float timeIncrease = 10.0f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Police car"))
        {
            CheckPointStack checkpointStack = other.GetComponent<CheckPointStack>();

            if (checkpointStack != null)
            {
                checkpointStack.passCheckpoint();
            }
        }
    }
}
