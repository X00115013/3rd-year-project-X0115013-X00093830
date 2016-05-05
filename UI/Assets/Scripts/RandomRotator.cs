using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    private Rigidbody rb;
    public float tumble; // holds max number floats
    
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        // how fast it rotates. Random.inUS returns a random vector 3 value 
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
