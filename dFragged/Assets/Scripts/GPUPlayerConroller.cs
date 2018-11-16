using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPUPlayerConroller : MonoBehaviour {

    public int speed;
    public float lookScale;
    public bool trackMouse = true;

    private Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rigidBody.AddForce(transform.forward * speed * Input.GetAxis("Vertical"), ForceMode.Impulse);
        rigidBody.AddForce(transform.right * speed * Input.GetAxis("Horizontal"), ForceMode.Impulse);

        if (trackMouse == true)
        {
            var playerRotation = transform.localEulerAngles;

            playerRotation.y += Input.GetAxis("Mouse X") * lookScale;
            playerRotation.x -= Input.GetAxis("Mouse Y") * lookScale;


            if ((playerRotation.x > 30) && (playerRotation.x < 180))
            {
                playerRotation.x = 30;
            }

            if ((playerRotation.x < 330) && (playerRotation.x > 180))
            {
                playerRotation.x = 330;
            }

            transform.localEulerAngles = playerRotation;

            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            trackMouse = !trackMouse;
        }
    }
}
