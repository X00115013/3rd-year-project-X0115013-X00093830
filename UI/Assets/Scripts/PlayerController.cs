using UnityEngine;
using System.Collections;

/* This is a way of storing & transferring
    its a complicated issue
*/
[System.Serializable]

public class BoundarySpace
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource audioSource;
    private float nextFire;

    public float speed;
    public float tilt;
    public Boundary boundary;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time>nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }

    // using phyiscs 
    void FixedUpdate()
    {
        // Gets input from the player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Vector3 gives direction & speed. 0.0f kets unity know its a floating point decimal number.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        
        rb = GetComponent<Rigidbody>();
        rb.velocity = movement * speed;

        /* Mathf is a collection of math functions
            clamp will clamp any given value between
            a min & max value. It's used here to clamp
            player ship to the game area.
        */
        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );

        // This is for the tilt along z-axis. times by negative tilt otherwise 
        // it goes in the opposite direction.  
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
