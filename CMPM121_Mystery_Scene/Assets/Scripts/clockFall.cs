using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockFall : MonoBehaviour
{
    Rigidbody rb;
    public bool isFall;
    public AudioSource fall;
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
            fall.PlayDelayed(0.5f);
            Global.count = Global.count + 1;
            //Debug.Log(global.count);
        }

    }
}
