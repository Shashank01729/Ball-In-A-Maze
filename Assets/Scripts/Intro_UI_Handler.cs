using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro_UI_Handler : MonoBehaviour
{
    public GameObject instrutionPanel;


    public void ToggleInstructionPanel(int toggle) {
        if (toggle == 1) {
            instrutionPanel.SetActive(false);
        } else {
            instrutionPanel.SetActive(true);
        }
    }


    /*
    public void ToggleInstructionPanel(string toggle){
        if (toggle == "false"){
            instrutionPanel.SetActive(false);
        }
        else if (toggle == "true") {
            instrutionPanel.SetActive(true);
        }
    }
    */

    public void ChangeCurrentScene(){
        Scene currentScene=SceneManager.GetActiveScene();
        int nextIndex=currentScene.buildIndex+1;
        SceneManager.LoadScene(nextIndex);
    }


}
