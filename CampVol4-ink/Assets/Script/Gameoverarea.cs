using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameoverarea : MonoBehaviour{
    [SerializeField]
    GameObject gameOverUI;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject==player.gameObject){
            //damage death 
            //UI表示
            Invoke("ShowGameOverUI", 2f);
        }else{
            return;
        }
    }

    private void ShowGameOverUI(){
        gameOverUI.SetActive(true);
    }
}
