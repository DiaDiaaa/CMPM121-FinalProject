using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Global 
{
    //public int count = 0;
    public bool[] stat = new bool[]{false,false,false,false,false};
    public int count = stat.Count(c => c == true);
}