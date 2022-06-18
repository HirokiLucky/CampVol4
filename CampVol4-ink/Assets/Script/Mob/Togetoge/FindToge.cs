using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindToge : MonoBehaviour
{
    private Animator anim;
    private GameObject toge;
    void Start()
    {
        toge = GameObject.Find("TurtleShell");
        anim = toge.GetComponent<Animator>();
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
