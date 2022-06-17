using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Bat")]
public class BatStatus : ScriptableObject
{
    public string batName = "Bat";
    public int hp = 3;
}
