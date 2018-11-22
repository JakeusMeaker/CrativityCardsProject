using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {

    public AudioClip fade;

    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
        source.loop = true;
    }

    public void Fade()
    {
        if (fade != null)
        {
            source.Stop();
            source.clip = fade;
            source.Play();
            source.loop = false;
        }
        
    }
}
