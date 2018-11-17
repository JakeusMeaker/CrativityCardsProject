using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float playerHealth = 5;
    public Slider playerHealthSlider;


    private void Start()
    {
        playerHealthSlider.value = 1;
    }


    public void TakeDamage(float dmg)
    {

        float percent = dmg / playerHealth;
        playerHealthSlider.value -= percent;

        Debug.Log(percent);

        playerHealth -= dmg;

        if (playerHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
