using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    public GameObject winUI;


    private void OnTriggerEnter(Collider other)
    {
        winUI.SetActive(true);
        Time.timeScale = 0;
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
