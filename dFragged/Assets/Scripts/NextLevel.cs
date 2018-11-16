using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour{

    public string sceneName;
   
    public void OnTriggerEnter(Collider other) // when a collifer touches this componants collider
    {
        LoadNextLevel();
    }

    public void LoadNextLevel() // creates a method called LoadNextLevel
    {
        SceneManager.LoadScene(sceneName); //Loads the scene which has been entered as a string
    }
}
