using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 21;
    public float fireRate = 1;
    public float range = 15;
    private int ammo = 16, maxAmmo = 16;
    public ParticleSystem muzzleFlash;
    public Transform bulletspawn;
    public AudioClip shotFX;  
    public AudioClip reloadFX;
    public AudioClip shootHFX;
    public AudioSource _audioSource;
    public Camera _cum;
    public float nextFire = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            //nextFire = Time.time + 1f / fireRate;
            Shoot(); 
        }
        
        if (Input.GetButtonDown("Reload"))
        {
            Reload();
        }
    }
    void Shoot()
    {
        if (ammo > 0)
        {
            _audioSource.PlayOneShot(shotFX);
            //Instantiate(muzzleFlash, bulletspawn.position, bulletspawn.rotation); 
            muzzleFlash.Play();
            RaycastHit hit;

            if (Physics.Raycast(_cum.transform.position, _cum.transform.forward, out hit, range))
            {
                Debug.Log("Cuming!!!");
            }
            ammo--;
            Debug.Log(ammo);
        }
        else _audioSource.PlayOneShot(shootHFX);
    }
    void Reload()
    {
        if (ammo == maxAmmo)
        {
            _audioSource.PlayOneShot(reloadFX);
            ammo += (maxAmmo - ammo);
            Debug.Log(ammo);
        }
    }
}
