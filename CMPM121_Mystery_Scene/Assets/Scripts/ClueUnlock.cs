using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueUnlock : MonoBehaviour
{
    public bool cluePC = false;
    public bool cluePic = false;
    public bool clueTV = false;
    public bool clueClock = false;
    public bool clueStove = false;
    public bool gameEnd = false;

    // Update is called once per frame
    void Update()
    {
        if(cluePC && cluePic && clueTV && clueClock && clueStove){
            gameEnd = true;
        }
    }
}
