using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Spider")]
public class SpiderStatus : ScriptableObject
{
    public string spiderName = "Spider";
    public int hp = 5;
}
