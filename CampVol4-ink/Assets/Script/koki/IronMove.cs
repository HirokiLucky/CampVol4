using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IronMove : MonoBehaviour
{
    Renderer target;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate () {
        if(target.isVisible){
            Rigidbody rb = this.GetComponent<Rigidbody>();
            Vector3 force = new Vector3 (-1.0f,0.0f,0.0f);
            rb.AddForce (force);
        }
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject==player.gameObject){
            Destroy(this.gameObject);
        }else{
            //plauyerrにダメージ
        }
    }
}
