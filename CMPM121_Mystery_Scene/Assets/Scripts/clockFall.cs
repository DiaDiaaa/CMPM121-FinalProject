using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockFall : MonoBehaviour
{
    Rigidbody rb;
    public bool isFall;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isFall = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(!isFall)
        {
            Debug.Log("collided");
            rb.isKinematic = false;
            isFall = true;
        }

    }
}
