using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Next scene
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Debug load sample scene
        SceneManager.LoadScene(2);
    }

    // Output message to simulate quitting game, works when built
    public void QuitGame()
    {
        Debug.Log("Quit game");
        // Does not work in Unity editor
        Application.Quit();
    }

    // Load start menu
    public void LoadMainMenu()
    {
        // Does not work in Unity editor
        SceneManager.LoadScene(1);
    }

    // Go to the next level in buildIndex
    public void NextLevel()
    {
        // Next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Debug load sample scene
        //SceneManager.LoadScene(3);
    }

    // Go to final level
    public void SurvivalLevel()
    {
        SceneManager.LoadScene(10);
    }
}
