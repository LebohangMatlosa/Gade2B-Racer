using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killa : MonoBehaviour, ICar
{

    public void initialize()
    {
        Debug.Log("Killa initialized");

    }

    public void drive()
    {
        Debug.Log("Killa is driving");
    }
}
