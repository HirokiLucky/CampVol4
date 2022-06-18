using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindSlime : MonoBehaviour
{
    private Animator anim;
    private GameObject slime;
    void Start()
    {
        slime = GameObject.Find("Slime");
        anim = slime.GetComponent<Animator>();
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
