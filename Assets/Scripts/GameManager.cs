using System.Collections;
using System.Collections.Generic;
// using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // We created a Singleton
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject restartButton;

    public void Awake()
    {
        if (instance == null) { 
            instance = this; 
        }

    }

    public void GameOverScreen(bool hasWon) {
        if (hasWon) winPanel.SetActive(true);
        else losePanel.SetActive(true);
        restartButton.SetActive(true);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
