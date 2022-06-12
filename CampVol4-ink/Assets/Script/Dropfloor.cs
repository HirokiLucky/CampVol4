using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropfloor : MonoBehaviour
{
    bool ft;
    public float dropspeed;
    public GameObject player;
    float count;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();
     count = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        if (ft == true){
            count += Time.deltaTime;
            Drop();
        }
    }

    void Drop(){
        if (count >= 1.0f){
            transform.Translate(0, dropspeed, 0);
        }
    }

     private void OnCollisionEnter(Collision other){
        if (other.gameObject == player.gameObject){
            count = 0; 
            ft = true;
        }
    }
}
