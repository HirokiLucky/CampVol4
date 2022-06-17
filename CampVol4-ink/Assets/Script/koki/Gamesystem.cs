using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamesystem : MonoBehaviour{
    public static bool isClear1 = false;
    public static bool isClear2 = false;
    public static bool isClear3 = false;
    // Start is called before the first frame update
    void Start(){
        GameObject c1 = GameObject.Find("c1");
        GameObject c12 = GameObject.Find("c12");
        GameObject c2 = GameObject.Find("c2");
        GameObject c22 = GameObject.Find("c22");
        GameObject c3 = GameObject.Find("c3");
        GameObject c32 = GameObject.Find("c32");
        var a1 = c1.GetComponent<BoxCollider>();
        var a2 = c12.GetComponent<BoxCollider>();
        var a3 = c2.GetComponent<BoxCollider>();
        var a4 = c22.GetComponent<BoxCollider>();
        var a5 = c3.GetComponent<BoxCollider>();
        var a6 = c32.GetComponent<BoxCollider>();
        
        if(isClear1==true){
            a1.isTrigger = false;
            a2.isTrigger = false;
        }
        if(isClear2==true){
            a3.isTrigger = false;
            a4.isTrigger = false;
        }
        if(isClear3==true){
            a5.isTrigger = false;
            a6.isTrigger = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
