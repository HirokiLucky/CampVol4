using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindBat : MonoBehaviour
{
    private Animator anim;
    private GameObject bat;
    void Start()
    {
        bat = GameObject.Find("Bat");
        anim = bat.GetComponent<Animator>();
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
