using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour {

    public int damage = 1;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");


        transform.LookAt(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            FindObjectOfType<PlayerHealth>().TakeDamage(damage);
        } else if (collision.transform.tag == "Wizzard")
        {
            return;
        }

        Destroy(gameObject);
    }
}
