using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
//latest
public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;
    private bool isRaceActive = false;
    public Button startTimeButton;
    public Button stopTimeButton;
    IEnumerator _timer;

    void TimerReset()
    {
        startTimeButton.interactable = true;
        stopTimeButton.interactable = false;
        timerText.text = "Time: 0.00";
    }

    private void Awake()
    {
        startTimeButton.onClick.AddListener(StartTimerOnClick);
        stopTimeButton.onClick.AddListener(StopTimerOnClick);
        TimerReset();
    }

    void StartTimerOnClick()
    {
        _timer = BeginTimer();
        StartCoroutine(_timer);
    }

    void StopTimerOnClick()
    {
        if(_timer != null)
        {
            StopCoroutine(_timer);
            _timer = null;
        }
        TimerReset();
    }
    IEnumerator BeginTimer(int remainingTime = 30)
    {
        startTimeButton.interactable = false;
        stopTimeButton.interactable = true;
        for (int i = remainingTime; i > 0; i--)
        {
            timerText.text = i.ToString("00");
            yield return new WaitForSeconds(1);
        }
        TimerReset();
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

