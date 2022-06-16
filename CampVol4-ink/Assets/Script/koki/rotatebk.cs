using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatebk : MonoBehaviour
{
    [SerializeField]
    private float rotatez = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotatez);
    }
}
