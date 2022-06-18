using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackToge : MonoBehaviour
{
    private GameObject toge;
    private Animator anim;
    void Start()
    {
        toge = GameObject.Find("TurtleShell");
        anim = toge.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetInteger("Range", 2);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetInteger("Range", 1);
        }
    }
}
