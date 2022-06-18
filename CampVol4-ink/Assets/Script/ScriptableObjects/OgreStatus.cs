using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Ogre")]
public class OgreStatus : ScriptableObject
{
    public string ogreName = "Ogre";
    public int hp = 10;
    public int maxhp = 10;
    public float speed = 2f;
}
