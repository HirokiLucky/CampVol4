using System;
using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]private GameObject player;
    private Vector3 generalCameraPos = new Vector3(2, 2, -15);
    private float speed = 1f;
    private float scroll;
    
    void Update()
    {
        var playerPos = player.transform.position;
        scroll = Input.GetAxis("Mouse ScrollWheel");
        generalCameraPos.z += scroll * speed;
        transform.position = playerPos + generalCameraPos;
    }
}
