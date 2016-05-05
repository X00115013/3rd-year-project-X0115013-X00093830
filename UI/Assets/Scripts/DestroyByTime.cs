using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

    public float lifetime;
	// Use this for initialization
	void Start () {
        // Wait for amount of time lifetime is set to then 
        // destroy itself when the time has expired
        Destroy(gameObject, lifetime);
	}
}
