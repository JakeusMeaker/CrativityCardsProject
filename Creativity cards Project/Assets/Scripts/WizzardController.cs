using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizzardController : MonoBehaviour {
    public GameObject player;
    public GameObject fireBall;
    public float fireBallImpulse = 5f;



	void Update ()
    {
        transform.parent.transform.LookAt(player.transform.position);
    }

    
    public void Attack()
    {
        GameObject inst = Instantiate(fireBall, transform.position + transform.TransformDirection( new Vector3(0, 0, 2)), new Quaternion(0, 0, 0, 0));

        inst.GetComponent<Rigidbody>().AddForce(transform.forward * fireBallImpulse, ForceMode.Impulse);
    }
}
