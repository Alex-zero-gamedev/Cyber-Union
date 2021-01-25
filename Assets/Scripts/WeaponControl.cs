using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 21;
    public float fireRate = 1;
    public float range = 15;
    public ParticleSystem muzzleFlash;
    public Transform bulletspawn;
    public AudioClip shotFX;
    public AudioSource _audioSource;
    public Camera _cum;
    public float nextFire = 0f;
    private bool Shuuting = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            //nextFire = Time.time + 1f / fireRate;
            Shuuting = true;
            if (Shuuting) Shoot(); 
        }

    }
    void Shoot()
    {
        _audioSource.PlayOneShot(shotFX);
        //Instantiate(muzzleFlash, bulletspawn.position, bulletspawn.rotation); 
        muzzleFlash.Play();
        RaycastHit hit;

        if (Physics.Raycast(_cum.transform.position, _cum.transform.forward, out hit, range))
        {
            Debug.Log("Cuming!!!");
        }
        Shuuting = false;
    }
}
