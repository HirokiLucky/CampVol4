using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour{
    public GameObject player;
    [SerializeField]
    GameObject goalUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        //goals字の処理
        if(other.gameObject==player.gameObject){
            //UIの表示
            Invoke("ShowgoalUI", 1f);
        }
    }

    private void ShowgoalUI(){
        goalUI.SetActive(true);
    }
}
