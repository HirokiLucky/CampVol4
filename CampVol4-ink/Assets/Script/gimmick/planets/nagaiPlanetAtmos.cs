using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagaiPlanetAtmos : MonoBehaviour
{
    private Vector3 targetPos = new Vector3(274, 73, 0);

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider col)
    {
        col.transform.position = Vector3.MoveTowards(col.transform.position, targetPos, Time.deltaTime * 10);
    }
}
