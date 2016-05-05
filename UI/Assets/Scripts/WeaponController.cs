using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour
{
    private AudioSource audioSource;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // fires on repeat like a while/ for loop
        InvokeRepeating("Fire", delay, fireRate);
    }

    // enemy fires at player
    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audioSource.Play();
    }
}
