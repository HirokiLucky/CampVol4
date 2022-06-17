using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadhab1 : MonoBehaviour{
    
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("koki_tutrials");
    }
}