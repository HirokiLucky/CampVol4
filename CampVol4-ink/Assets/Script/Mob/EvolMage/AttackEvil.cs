using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEvil : MonoBehaviour
{
    private GameObject evil;
    private Animator anim;
    void Start()
    {
        evil = GameObject.Find("EvilMage");
        anim = evil.GetComponent<Animator>();
    }
    
    void DelayAttackStart()
    {
        var ex = GameObject.Find("Streamream");
        var col = ex.GetComponent<SphereCollider>();
        col.enabled = true;
        var orbital = ex.GetComponent<ParticleSystem>();
        orbital.Play();
    }
    
    void DelayAttackFinish()
    {
        var ex = GameObject.Find("Streamream");
        var col = ex.GetComponent<SphereCollider>();
        col.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke(nameof(DelayAttackStart), 1f);
            Invoke(nameof(DelayAttackFinish), 3.5f);
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
