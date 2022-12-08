using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setFire : MonoBehaviour
{
    public AudioSource fire;
    public GameObject flame;
    public GameObject light;
    public bool isFired;

    void Start()
    {
        flame.SetActive(false);
        light.SetActive(false);
        isFired = false;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered");
        if(!isFired){
            flame.SetActive(true);
            light.SetActive(true);
            fire.PlayDelayed(0.5f);
            isFired = true;
            Global.count += 1;
            //Debug.Log("counter");
            //Debug.Log(Global.count);
        }
    }
}
