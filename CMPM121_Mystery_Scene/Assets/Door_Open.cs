using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour
{
    public GameObject closed_door;
    public AudioSource open;
    public bool isPlayed = false;
    void Update()
    {
        if(Global.count == 5){
            if(!isPlayed)
            {
                open.PlayDelayed(1.0f);
                isPlayed = true;
            }

            closed_door.SetActive(false);

        }
    }
}
