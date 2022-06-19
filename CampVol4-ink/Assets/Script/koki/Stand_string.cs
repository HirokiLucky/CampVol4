using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stand_string : MonoBehaviour
{
    float count;
    [SerializeField] GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.time;
        showsText();
    }

    void showsText(){
        if (count >= 0.4f && count <= 2.5f){
            Text.SetActive(true);
        }
        if(count > 5.0f){
            Destroy(gameObject);
        }
    }
}