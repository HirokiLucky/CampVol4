using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bound : MonoBehaviour
{
    private UnityChanScript unityChanScript;
    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(transform.up * 1500f, ForceMode.Impulse);
    }
}
