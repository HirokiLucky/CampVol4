using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGolem : MonoBehaviour
{
    [SerializeField] private GameObject mob;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mob.transform.Rotate(new Vector3(0, 180, 0));
        }
    }
}
