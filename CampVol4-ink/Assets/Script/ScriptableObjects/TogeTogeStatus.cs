using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TogeToge")]
public class TogeTogeStatus : ScriptableObject
{
    public string togetogeName = "TogeToge";
    public int hp = 3;
    public int maxhp = 3;
    public float speed = 1f;
}
