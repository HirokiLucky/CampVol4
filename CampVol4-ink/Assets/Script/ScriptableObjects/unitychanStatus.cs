using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class unitychanStatus : MonoBehaviour
{
    [NonSerialized] public string name = "UnityChan";
    [NonSerialized] public int hp = 10;
    [NonSerialized] public bool ult = false;
    [NonSerialized] public bool skill = true;

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
