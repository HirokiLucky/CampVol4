using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;

public class All : MonoBehaviour
{
    private Animator anim;
    private GameObject slime;
    
    [SerializeField] private SlimeStatus status;
    [SerializeField] private unitychanStatus unityStatus;
    void Start()
    {
        slime = GameObject.Find("Slime");
        anim = slime.GetComponent<Animator>();
    }

    
    
    void DelayMethod()
    {
        anim.SetBool("Receive", false);
    }
    
    void DelayDestroy()
    {
        Destroy(slime);
    }

    private void OnTriggerEnter(Collider other)
    {
        print(1111);
        if (other.CompareTag("skill"))
        {
            print(3333);
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
            print(2222);
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
