using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntivirusScript : MonoBehaviour {

    public GameObject exitDoor;
    public GameObject[] enemies;

   

    // Update is called once per frame
    void Update ()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0)
        {
            Destroy(gameObject);
        }
    }
}
