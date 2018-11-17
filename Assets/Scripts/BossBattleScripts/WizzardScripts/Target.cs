using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 50;

    public GameObject exitDoor;
    public Slider healthImg;

    private void Start()
    {
        healthImg.value = 1;
    }

    public void TakeDamage(float amount)
    {
        float percent = amount / health;
        healthImg.value -= percent;

        health -= amount;

        if (health <= 0)
        {
            Die();
            Destroy(healthImg);
        }
    }
    void Die()
    {
        Destroy(exitDoor);
        Destroy(gameObject);

    }
}
