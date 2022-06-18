using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBat : MonoBehaviour
{
    private GameObject bat;
    private Animator anim;
    void Start()
    {
        bat = GameObject.Find("Bat");
        anim = bat.GetComponent<Animator>();
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
