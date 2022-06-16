using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagaiPlanet1 : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 3) * Time.deltaTime);
    }

    
}
