using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class branch_judge : MonoBehaviour
{
    [SerializeField] private DragonStatus status;
    [SerializeField] private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if(status.hp<=0){
            return;
        }else{
            //Player.hp=0;
        }
    }
}
