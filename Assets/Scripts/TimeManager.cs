using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float timeValue = 60f;
    private bool isTimerRunning = false;
    private float currentTime;
    public Text timerText;

    private void Start()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }

    private void Update()
    {
        if (isTimerRunning) {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0.0f) { 
                currentTime = 0.0f;
                isTimerRunning=false;
            }
            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime/60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);
        timerText.text = string.Format("{00:00}:{01:00}",minutes,seconds);
    }

}
