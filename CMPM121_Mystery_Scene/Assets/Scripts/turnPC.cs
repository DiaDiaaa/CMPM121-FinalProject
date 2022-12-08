using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnPC : MonoBehaviour
{
    public GameObject pc_screen;
    public Global global;
    public bool isTurned;
    public float timeRemain;

    void Start(){
        pc_screen.SetActive(false);
        isTurned = false;
    }
    void OnTriggerEnter(Collider other){
        Debug.Log("Object entered");
        if(!isTurned){
            pc_screen.SetActive(true);
            isTurned = true;
            global.stat[0] = true;
            //global.count = global.count + 1;
            Debug.Log("counter");
            Debug.Log(global.count);
        }
    }
}