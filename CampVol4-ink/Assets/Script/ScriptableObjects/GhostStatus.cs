using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Ghost")]
public class GhostStatus : ScriptableObject
{
    public string ghostName = "Ghost";
    public int hp = 30;
}
