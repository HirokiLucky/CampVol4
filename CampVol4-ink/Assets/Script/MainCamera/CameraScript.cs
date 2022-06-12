using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]private GameObject player;
    private Vector3 generalCameraPos = new Vector3(2, 2, -8);
    
    void Update()
    {
        var playerPos = player.transform.position;
        transform.position = playerPos + generalCameraPos;
    }
}
