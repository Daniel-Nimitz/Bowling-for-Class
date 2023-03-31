using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public void OnStartClicked() {
        SceneManager.LoadScene("BowlingAlly");
    }

    public void OnQuitClicked() {
        Application.Quit();
        Debug.Log("Game Would Quit");
    }

    public void OnCreditsClicked() { 
    
    }
}
