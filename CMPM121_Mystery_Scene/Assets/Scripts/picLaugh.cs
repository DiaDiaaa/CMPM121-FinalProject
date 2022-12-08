using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picLaugh : MonoBehaviour
{
    public AudioSource laugh;
    public bool isLaughed;

    void Start(){
        isLaughed = false;
    }
    void OnTriggerEnter(Collider other){
        Debug.Log("Object entered");
        if(!isLaughed){
            laugh.Play();
            isLaughed = true;
            Global.count += 1;
            //Debug.Log("counter");
            //Debug.Log(Global.count);
        }
    }
}
