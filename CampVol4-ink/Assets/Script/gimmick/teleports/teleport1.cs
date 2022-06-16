using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport1 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(275, 130, 0);
    }
}
