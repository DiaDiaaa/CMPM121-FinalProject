using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Interaction : MonoBehaviour
{
    [SerializeField] private GameObject _Clue_Object_01;

    [SerializeField] private GameObject _Clue_UI_01;
    
    
    private void OnCollisionEnter(Collision col)
    {
        
        Debug.Log("collide");
        if (col.gameObject.name == _Clue_Object_01.name)
        {
            
            _Clue_UI_01.SetActive(true);
        }
    }
}
