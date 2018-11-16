using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float dmg = 10f;
    public float range = 100;
    public float fireRate = 0.2f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;



    private Animator animator;


    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());

        }
    }

    IEnumerator Shoot()
    {
        animator.SetBool("Shooting", true);
        muzzleFlash.Play();


        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            if (hit.transform.GetComponent<EnemyScript>() != null)
            {
                hit.transform.GetComponent<EnemyScript>().TakeDamage(1);
            }

            GameObject impact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f);
        }

        yield return new WaitForSeconds(fireRate);

        animator.SetBool("Shooting", false);
    }
}
