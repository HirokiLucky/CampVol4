using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathdrop : MonoBehaviour{
    [SerializeField]
    GameObject gameOverUI;
    public GameObject player;
    public GameObject ground;
 
    void Update()
    {
        Vector3 target = player.transform.position;
        float distance = Vector3.Distance(target,this.transform.position);
 
        if(distance < 45.0f){
            deathGravity();
        }
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject==ground.gameObject){
            Destroy(this.gameObject);
        }else{
            //plauyerrを殺す
            Invoke("ShowGameOverUI", 2f);
        }
    }
 
    void deathGravity()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void ShowGameOverUI(){
        gameOverUI.SetActive(true);
    }
}
