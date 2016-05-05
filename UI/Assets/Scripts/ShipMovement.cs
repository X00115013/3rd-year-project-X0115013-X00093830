using UnityEngine;
using System.Collections;

[System.Serializable]

public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class ShipMovement : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    private int count;
    public GameObject shot;
    public float tilt;
    private float nextFire;
    public Transform shotSpawn;
    public float fireRate;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb = GetComponent<Rigidbody>();

        rb.AddForce(movement * speed);
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
    void OnTriggerEnter(Collider other)
    {
    }
}
