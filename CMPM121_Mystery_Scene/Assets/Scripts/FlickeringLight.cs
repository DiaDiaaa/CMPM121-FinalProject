using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    //https://www.youtube.com/watch?v=DNMdu3kylec
    public bool isFlickering = false;
    public float timeDelay;

    // Update is called once per frame
    void Update()
    {
        if(isFlickering == false){
            StartCoroutine(FlickeringControl());
        }
    }
    IEnumerator FlickeringControl(){
        isFlickering = true;
        this.gameObject.GetComponent<Light>().intensity = 0.31f;
        timeDelay = Random.Range(0.01f, 0.1f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().intensity = 0.4f;
        timeDelay = Random.Range(0.01f, 0.4f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
        //Debug.Log(isFlickering);
    }
}
