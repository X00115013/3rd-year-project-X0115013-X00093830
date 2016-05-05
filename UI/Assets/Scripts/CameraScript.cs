using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{

    public GameObject Ship;
    private Vector3 offSet;


    // Use this for initialization
    void Start()
    {
        offSet = transform.position - Ship.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Ship.transform.position + offSet;
    }
}
