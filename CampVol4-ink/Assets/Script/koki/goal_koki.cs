using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goal_koki : MonoBehaviour{
    [SerializeField] GameObject goalUI;

    void OnTriggerEnter(Collider other){
        //goalsの処理
        if(other.gameObject.CompareTag("Player")){
            Invoke("ShowGoalUI", 3f);
            Gamesystem.isClear1=true;
        }
    }
    private void ShowGoalUI()
    {
        goalUI.SetActive(true);
    }
}
