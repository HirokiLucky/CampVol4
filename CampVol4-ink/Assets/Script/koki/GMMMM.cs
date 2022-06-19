using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMMMM : MonoBehaviour{
    [SerializeField] GameObject GCUI;
    [SerializeField] private GhostStatus status;
    void Update(){
        //goalsの処理
        if(status.hp<=0){
            Invoke("ShowGoalUI", 0.1f);
        }
    }
    private void ShowGoalUI()
    {
        GCUI.SetActive(true);
    }
}
