using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDragon
    : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    [SerializeField] private GameObject unitychan;
    [SerializeField] private DragonStatus status;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (anim.GetInteger("Range") == 1)
        {
            transform.LookAt(unitychan.transform);
            rb.velocity = transform.forward * status.speed;
        }
    }
}
