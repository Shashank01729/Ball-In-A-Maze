using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int _score = 0;
    public Text scoreText;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void addScore(int points)
    {
        _score += points;
        Debug.Log(_score);
        scoreText.text = "Score: "+_score.ToString();
    }

    public int getScore(){
        return _score;
    }
}
