﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour {

    public GameObject doorEnter;
    public GameObject wizzard;
    public GameObject winUI;
    public AudioSource source;

    bool started = false;

    private void Start()
    {
        source.Stop();
        wizzard.SetActive(false);
        winUI.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && !started)
        {
            started = true;
            Debug.Log("Player 1 has entered the Arena!");
            doorEnter.transform.position += new Vector3(0, 9.83f, 0);

            wizzard.SetActive(true);
            wizzard.transform.position = new Vector3(0, 10, 25);

            source.Play();
            source.loop = true;
        }
    }
}
