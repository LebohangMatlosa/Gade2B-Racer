using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float racetimer = 60.0f;

    public void IncreaseTimer(float amount)
    {
        racetimer += amount;
    }

}

