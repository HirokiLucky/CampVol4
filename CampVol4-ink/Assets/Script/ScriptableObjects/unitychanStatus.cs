using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/unitychan")]
public class unitychanStatus : ScriptableObject
{
    public string name = "UnityChan";
    public int hp = 10;
    public int life = 100;
    public int ult = 10;
    public int skill = 2;
    public int star = 0;
}
