using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllOrc : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    [SerializeField] private OgreStatus status;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (anim.GetInteger("Range") == 1)
        {
            rb.velocity = transform.forward * status.speed;
        }
    }
}
