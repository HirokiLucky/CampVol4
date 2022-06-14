using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    Vector3 targetPos;
    private Vector3 startPos;
    
    void Start()
    {
        targetPos = new Vector3(110, 20, 1);
        startPos = new Vector3(75, 20, 1);
    }
    
    void FixedUpdate()
    {
        CheckPos();
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime);
    }

    void CheckPos()
    {
        if (transform.position == targetPos)
        {
            Destroy(gameObject);
        }
    }
}
