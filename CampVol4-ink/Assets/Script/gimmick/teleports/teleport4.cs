using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport4 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(524, 57, 0);
    }
}
