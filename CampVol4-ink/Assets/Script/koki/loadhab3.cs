using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadhab3 : MonoBehaviour{
    
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("nagaiArea2");
    }
}