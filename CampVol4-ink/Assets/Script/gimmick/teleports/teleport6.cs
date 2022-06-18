using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport6 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(1179, 22, 0);
    }
}
