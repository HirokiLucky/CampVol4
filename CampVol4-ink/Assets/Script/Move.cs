using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called oncae per frame
    private void FixedUpdate()
    {
        if (Input.GetKey("left shift")&&Input.GetKey("w")||Input.GetKey("a")||Input.GetKey("s")||Input.GetKey("d")){
            rb.velocity = new Vector3(Input.GetAxis("Horizontal")*20, Input.GetAxis("Vertical")*20, 0);
        }else{
            rb.velocity = new Vector3(Input.GetAxis("Horizontal")*10, Input.GetAxis("Vertical")*10, 0);
        }
    }
    public void OnCollisionEnter(Collision x){
        print("tintin");
    }
}
