using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;

public class BodyToge : MonoBehaviour
{
    private Animator anim;
    private GameObject toge;
    
    [SerializeField] private TogeTogeStatus status;
    [SerializeField] private unitychanStatus unityStatus;
    void Start()
    {
        toge = GameObject.Find("TurtleShell");
        anim = toge.GetComponent<Animator>();
    }

    
    
    void DelayMethod()
    {
        anim.SetBool("Receive", false);
    }
    
    void DelayDestroy()
    {
        Destroy(toge);
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
