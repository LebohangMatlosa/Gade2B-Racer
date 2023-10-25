using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Car").SendMessage("Finish");
    }
}
