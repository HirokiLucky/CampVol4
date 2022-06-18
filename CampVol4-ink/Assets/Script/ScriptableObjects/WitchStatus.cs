using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Witch")]
public class WitchStatus : ScriptableObject
{
    public string witchName = "Witch";
    public int hp = 10;
    public int maxhp = 10;
    public float speed = 1f;
}
