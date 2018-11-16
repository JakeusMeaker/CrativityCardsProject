using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizzardController : MonoBehaviour {
    public GameObject player;
    public GameObject fireBall;
    public float fireBallImpulse = 5f;
    public float wizzardSpeed = 1f;

    float fraction = 0;

    public GameObject startNode;
    public GameObject[] nodes;

    Vector3 posA;
    Vector3 posB;
    bool inMotion = false;

    private void Start()
    {
        posA = startNode.transform.position + new Vector3(-20, 0, 0);
        transform.position = posA;
        posB = startNode.transform.position;
    }
    
    void Update ()
    {
        transform.LookAt(player.transform.position);
        
        MoveToWayPoint();
    }

    void MoveToWayPoint ()
    {
        if (!inMotion)
        {
            posA = posB;

            posB = nodes[Random.Range(0, nodes.Length)].transform.position;

            //Debug.Log(posA + posB);

            fraction = 0;
            inMotion = true;
        } else
        {
            transform.position = Vector3.Lerp(posA, posB, fraction);
            fraction += wizzardSpeed * Time.deltaTime;

            if (fraction >= 1)
            {
                inMotion = false;
            }


        }
    }
    
    public void Attack()
    {
        GameObject inst = Instantiate(fireBall, transform.position + transform.TransformDirection( new Vector3(0, 0, 2)), new Quaternion(0, 0, 0, 0));

        inst.GetComponent<Rigidbody>().AddForce(transform.forward * fireBallImpulse, ForceMode.Impulse);
    }
}
