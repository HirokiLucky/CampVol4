using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGolem : MonoBehaviour
{
    private GameObject golem;
    private Animator anim;
    void Start()
    {
        golem = GameObject.Find("Golem");
        anim = golem.GetComponent<Animator>();
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
