using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHandler : MonoBehaviour
{
    public GameObject lightTrigger;
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            // Debug.Log("left click");
            if(lightTrigger.activeSelf != true){
                lightTrigger.SetActive(true);
            }else{
                lightTrigger.SetActive(false);
            }
            // Debug.Log(lightTrigger.activeSelf);
        }
    }
}
