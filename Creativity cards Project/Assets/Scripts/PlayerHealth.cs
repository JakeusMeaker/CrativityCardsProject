using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int playerHealth = 5;


    public void TakeDamage(int dmg)
    {
        playerHealth -= dmg;
        Debug.Log("Oof!");

        if (playerHealth <= 0)
        {
            Debug.Log("Dead");
        }
    }

}
