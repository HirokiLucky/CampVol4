using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDragon : MonoBehaviour
{
    private GameObject dragon;
    private Animator anim;
    void Start()
    {
        dragon = GameObject.Find("Dragon");
        anim = dragon.GetComponent<Animator>();
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
