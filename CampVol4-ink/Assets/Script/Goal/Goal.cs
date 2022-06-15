using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour{
    [SerializeField] TextMeshProUGUI goalUI;

    void OnTriggerEnter(Collider other){
        //goals字の処理
        if(other.gameObject.CompareTag("Player")){
            goalUI.SetText("Goal!!");
        }
    }
}
