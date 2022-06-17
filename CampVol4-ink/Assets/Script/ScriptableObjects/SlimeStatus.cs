using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Slime")]
public class SlimeStatus : ScriptableObject
{
    public string slimeName = "Slime";
    public int hp = 50;
    public float speed = 2f;
}
