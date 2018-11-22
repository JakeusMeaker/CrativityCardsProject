using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public float dmg = 10f;
    public float range = 100;

    public Camera fpsCam;
    public GameObject muzzleFlash;
    public GameObject impactEffect;
    public Animator anim;

    float counter = 10;

    private void Start()
    {
        muzzleFlash.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            if (anim != null)
            {
                anim.SetBool("Shoot", true);
            }
            Shoot();
        }

        if (Input.GetButtonUp("Fire1"))
        {
            if (anim != null)
            {
                anim.SetBool("Shoot", false);
            }
        }

        //Debug.Log(muzzleFlash.activeSelf);

        if (muzzleFlash.activeSelf)
        {
            if (counter <= 0)
            {
                counter = 10;
                muzzleFlash.SetActive(false);
            } else
            {
                counter--;
                //Debug.Log(counter);
            }
        }

    }

    void Shoot()
    {
        if (muzzleFlash != null)
        {
            muzzleFlash.SetActive(true);
        }


        RaycastHit hit;

        if (anim != null)
        {
            anim.SetBool("Shoot", true);
        }

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(dmg);
            }

            if (impactEffect != null)
            {
                GameObject impact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impact, 2f);
            }
        }
    }
}
