using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public void OnStartNewGame()
    {
        SceneManager.LoadScene("Scenes/Hard drive");
    }

    public void OnDeath()
    {
        SceneManager.LoadScene("Scenes/Death Screen");
    }

    public void OnGoToStartScreen()
    {
        SceneManager.LoadScene("Scenes/Start Screen");
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
