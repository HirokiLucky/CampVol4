using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if(status.hp<=0){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other){
        
    }
}
