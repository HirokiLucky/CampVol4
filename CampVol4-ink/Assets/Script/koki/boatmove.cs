using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatmove : MonoBehaviour{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start(){
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        Transform myTrans = this.transform;
        Vector3 myposition = myTrans.position;
        if(myposition.x < -50){
            this.rb.velocity = new Vector3(20f, 0, 0);
        }
    }
}
