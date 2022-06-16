using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagaiPlanet1 : MonoBehaviour
{
    
    
    
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 3) * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision col)
    {
        float y = col.transform.position.y - 73;
        float x = col.transform.position.x - 273;
        double cul = Math.Atan(y / x);
        float pos = (360 * (float)cul) / 2 * (float)Math.PI;
        //col.transform.rotation = Quaternion.Euler(new Vector3(col.transform.rotation.x, 90, 0));
        //col.transform.Rotate(new Vector3(0, 0, pos));
    }

    
}
