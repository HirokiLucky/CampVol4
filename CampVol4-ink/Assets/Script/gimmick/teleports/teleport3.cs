using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport3 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(350, 217, 0);
    }
}
