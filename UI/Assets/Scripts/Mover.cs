using UnityEngine;
using System.Collections;

/*
    This is for a lazer bolt to be fired and move itself
*/
public class Mover : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // local z-axis is also know as tranform forward
        rb.velocity = transform.forward * speed;
    }
}
