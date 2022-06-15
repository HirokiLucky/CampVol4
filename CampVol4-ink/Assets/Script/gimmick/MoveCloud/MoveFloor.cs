using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Animations;

public class MoveFloor : MonoBehaviour
{
    Vector3 targetPos;
    private Vector3 startPos;
    [SerializeField]private GameObject cloud;
    
    void Start()
    {
        targetPos = new Vector3(110, 15, 1);
        startPos = new Vector3(80, 15, 1);
    }
    
    void FixedUpdate()
    {
        CheckPos();
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * 2);
    }

    void CheckPos()
    {
        if (transform.position == targetPos)
        {
            transform.DetachChildren();
            Instantiate(cloud, startPos, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    
    
    
}
