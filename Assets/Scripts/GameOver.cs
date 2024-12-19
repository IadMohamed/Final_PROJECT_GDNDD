using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public CanvasGroup OptionPanel;

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        // Assuming you have a "MainMenu" scene index:
        SceneManager.LoadScene(0); // Replace 0 with the actual index of your Main Menu scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}