using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 21;
    public float fireRate = 1;
    public float force = 155;
    public float range = 15;
    public ParticleSystem muzzleFlash;
    public AudioClip shotFX;
    public AudioSource _audioSource;
    public Transform bulletSpawn;
    public Camera _cum;
    public float nextFire = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            nextFire = Time.time + 1f / fireRate;
            Shoot(); 
        }

    }
    void Shoot()
    {
        _audioSource.PlayOneShot(shotFX);
        //Instantiate(muzzleFlash, bulletSpawn.position, bulletSpawn.rotation);
        RaycastHit hit;
        if (Physics.Raycast(_cum.transform.position, _cum.transform.forward, out hit, range))
        {
            Debug.Log("AHHHHH i'm Cuming!");
            muzzleFlash.Play();
            //GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal))
            //Destroy(impact, 2f);

            if (hit.rigidbody != null) hit.rigidbody.AddForce(-hit.normal * force);
        }
    }
}
