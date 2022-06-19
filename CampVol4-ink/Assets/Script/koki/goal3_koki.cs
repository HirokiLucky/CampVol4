using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goal3_koki : MonoBehaviour{
    [SerializeField] GameObject goalUI;

    void OnTriggerEnter(Collider other){
        //goalsの処理
        if(other.gameObject.CompareTag("Player")){
            Invoke("ShowGoalUI", 0.1f);
            Gamesystem.isClear3=true;
        }
    }
    private void ShowGoalUI()
    {
        goalUI.SetActive(true);
    }
}

