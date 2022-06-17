using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/unitychan")]
public class unitychanStatus : ScriptableObject
{
    public string name = "UnityChan";
    public int hp = 10;
    public bool ult = false;
    public bool skill = true;
    public int star = 0;
}