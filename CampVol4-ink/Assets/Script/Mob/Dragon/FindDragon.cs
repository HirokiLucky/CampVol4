using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDragon : MonoBehaviour
{
    private Animator anim;
    private GameObject dragon;
    void Start()
    {
        dragon = GameObject.Find("Dragon");
        anim = dragon.GetComponent<Animator>();
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
