using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour {

    public int damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            FindObjectOfType<PlayerHealth>().TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
