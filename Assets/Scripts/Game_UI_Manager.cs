using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_UI_Manager : MonoBehaviour
{
    public void ChangeCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int nextIndex = currentScene.buildIndex + 1;
        // SceneManager.LoadScene(nextIndex);
        Debug.Log(currentScene.buildIndex);
    }

}
