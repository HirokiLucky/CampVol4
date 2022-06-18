using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport5 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(955, 20, 0);
    }
}
