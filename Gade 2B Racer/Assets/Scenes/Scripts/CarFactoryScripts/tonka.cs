using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tonka : MonoBehaviour , ICar
{
    public void initialize()
    {
        Debug.Log("tonka initialized");

    }

    public void drive()
    {
        Debug.Log("Tonka is driving");
    }
}
