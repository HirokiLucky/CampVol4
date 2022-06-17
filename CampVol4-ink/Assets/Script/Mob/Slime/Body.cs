using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;

public class Body : MonoBehaviour
{
    [NonSerialized] public Animator anim;
    private Rigidbody rb;
    [SerializeField] private SlimeStatus status;
    [SerializeField] private unitychanStatus unityStatus;
    private GameObject unityChan;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        unityChan = GameObject.Find("Unity-Chanme_01 SD Unity-Chan");
    }

    private void Update()
    {
        if (anim.GetInteger("Range") == 1)
        {
            
            rb.velocity = new Vector3(status.speed, 0, 0);
        }
    }

    void DelayMethod()
     {
         anim.SetBool("Receive", false);
     }
    
    void DelayDestroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("skill"))
        {
            status.hp -= unityStatus.skill;
            anim.SetInteger("HP", status.hp);
            if (status.hp < 1)
            {
                Invoke(nameof(DelayDestroy), 2f);
            }
            anim.SetBool("Receive", true);
            Invoke(nameof(DelayMethod), 0.5f);
        }
        if (other.CompareTag("ult"))
        {
            status.hp -= unityStatus.ult;
            anim.SetInteger("HP", status.hp);
            if (status.hp < 1)
            {
                Invoke(nameof(DelayDestroy), 2f);
            }
            anim.SetBool("Receive", true);
            Invoke(nameof(DelayMethod), 0.5f);
        }
    }
}
