using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    public GameObject winUI;
    public GameObject player;

    GPUPlayerConroller mouse;

    private void Start()
    {
        mouse = player.GetComponent<GPUPlayerConroller>();
        Debug.Log(mouse);
    }

    private void OnTriggerEnter(Collider other)
    {
        winUI.SetActive(true);
        Time.timeScale = 0;
        mouse.trackMouse = false;
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
