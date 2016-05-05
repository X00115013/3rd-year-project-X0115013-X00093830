using UnityEngine;
using System.Collections;

public class QueAndTip : MonoBehaviour {

    public GameObject QueTip;
    private Vector3 offSet;
    public float speed;

    // Use this for initialization
    void Start()
    {
        offSet = transform.position - QueTip.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = QueTip.transform.position + offSet;
    }
}
