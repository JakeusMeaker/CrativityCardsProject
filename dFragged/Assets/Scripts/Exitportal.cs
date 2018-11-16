using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitportal : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(variable());
    }

    IEnumerator variable()
    {
        yield return new WaitForSeconds(1f);

        FindObjectOfType<GameManager>().NextLevel();
    }
}
