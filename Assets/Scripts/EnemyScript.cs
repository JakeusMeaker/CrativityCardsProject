using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int health;
    public int rotation = 1;
    public Transform player;
    public float fleeSpeed = 2;
    public bool isFleeing = false;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void TakeDamage (int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            Die();
        }
    }
	
    void Die()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        /*if(Vector3.Distance(transform.position, player.position) < 15)
        {
            Debug.Log("Can see the player");
            transform.LookAt(player.transform);
            
        }*/

        if (isFleeing)
        {
            Flee();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I SEE CHUUU");
        if (other.tag == ("Player"))
        {
            isFleeing = true;            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            isFleeing = false;
        }
    }

    void Flee()
    {
        Debug.Log("Run Away!");
        transform.position = Vector3.MoveTowards(transform.position, player.position, -fleeSpeed * Time.deltaTime);

    }
}
