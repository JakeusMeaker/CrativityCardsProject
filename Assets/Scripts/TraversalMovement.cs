using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraversalMovement : MonoBehaviour
{

    public float forwardSpeed = 15;
    public float sideSpeed = 10;

    private void Update()
    {
        float axis = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(axis * Time.deltaTime * sideSpeed, 0, forwardSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("yes");
        if (collision.collider.tag == "object")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
