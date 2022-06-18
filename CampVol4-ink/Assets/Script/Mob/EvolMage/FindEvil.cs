using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEvil : MonoBehaviour
{
    private Animator anim;
    private GameObject evil;
    void Start()
    {
        evil = GameObject.Find("EvilMage");
        anim = evil.GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetInteger("Range", 1);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetInteger("Range", 0);
        }
    }
}
