using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadhab3 : MonoBehaviour{
    
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("nagaiArea2");
        }
    }
}