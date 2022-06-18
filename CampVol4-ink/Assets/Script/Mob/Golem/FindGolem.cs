using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGolem : MonoBehaviour
{
    private Animator anim;
    private GameObject golem;
    void Start()
    {
        golem = GameObject.Find("Golem");
        anim = golem.GetComponent<Animator>();
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
