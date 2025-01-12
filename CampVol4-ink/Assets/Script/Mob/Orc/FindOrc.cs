using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindOrc : MonoBehaviour
{
    private Animator anim;
    private GameObject orc;
    void Start()
    {
        orc = GameObject.Find("Orc");
        anim = orc.GetComponent<Animator>();
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
