using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;
    private bool isRaceActive = false;

    void Start()
    {
        timerText.text = "Time: 0.00";
    }

    void Update()
    {
        if (isRaceActive)
        {
            float currentTime = Time.time - startTime;
            string minutes = Mathf.Floor(currentTime / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("00.00");
            timerText.text = "Time: " + minutes + ":" + seconds;
        }

    }

    public void StartRaceTimer()
    {
        startTime = Time.time;
        isRaceActive = true;
    }

    public void StopRaceTimer()
    {
        isRaceActive = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        StartRaceTimer();
        Debug.Log("The Racec Has Started");
    }
}

