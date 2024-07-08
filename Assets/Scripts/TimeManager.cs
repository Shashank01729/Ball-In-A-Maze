using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public CollectableManager collectableManager;
    public float timeValue = 60f;
    private bool isTimerRunning = false;
    private float currentTime;
    public Text timerText;
    // public Text gameMsg;

    private void Start()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }

    private void Update()
    {
        if (isTimerRunning) {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0.0f && !collectableManager.allCoinsCollected) { 
                currentTime = 0.0f;
                isTimerRunning=false;
                Debug.Log("Game Lost");
                // gameMsg.text = "  GAME LOST";
                GameManager.instance.GameOverScreen(false);
            }

            if (collectableManager.allCoinsCollected) {
                Debug.Log("Game Won");
                isTimerRunning = false;
                // gameMsg.text = "  GAME WON";
                GameManager.instance.GameOverScreen(true);
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