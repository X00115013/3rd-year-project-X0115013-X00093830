using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour {
    private Vector3 startPosition;

    public float scrollSpeed; 
    public float tileSizeZ;// length of the tile

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Mathf.Repeat loop value so it never larger than lenght & smaller than 0
        // Time. time is time in the game thus the repeat is lenght of tile so it looks seamlessly
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);

        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
