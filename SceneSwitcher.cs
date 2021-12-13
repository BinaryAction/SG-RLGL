using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("RedLightGreenLight");
    }

    public void viewInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void viewMainMenu()
    {
        Debug.Log("Switching to main menu");
        SceneManager.LoadScene("MainMenu");
    }
}
