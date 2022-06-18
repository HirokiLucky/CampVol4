using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOrc : MonoBehaviour
{
    private GameObject orc;
    private Animator anim;
    void Start()
    {
        orc = GameObject.Find("Orc");
        anim = orc.GetComponent<Animator>();
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
