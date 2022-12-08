using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTV : MonoBehaviour
{
    public GameObject white_screen;
    public GameObject screen_light;
    public AudioSource noise;
    public bool isTurned;
    public float timeRemain;

    void Start(){
        white_screen.SetActive(false);
        screen_light.SetActive(false);
        isTurned = false;
    }
    void OnTriggerEnter(Collider other){
        Debug.Log("Object entered");
        if(!isTurned){
            white_screen.SetActive(true);
            screen_light.SetActive(true);
            noise.Play();
            isTurned = true;
            Global.count = Global.count + 1;
            //Debug.Log(Global.count);
            timeRemain = 5f;
        }
    }

    void Update(){
        if(isTurned){
            timeRemain -= Time.deltaTime;
            if(timeRemain <= 0f){
                white_screen.SetActive(false);
                screen_light.SetActive(false);
                noise.Stop();
            }
        }
    }
}
