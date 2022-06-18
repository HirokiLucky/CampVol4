using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TB_stand : MonoBehaviour
{
    float count;
    [SerializeField] GameObject Title;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        showsTitle();
    }

    void showsTitle(){
        if (count >= 3.0f){
            Invoke("ShowTitle", 0.1f);
        }
    }

    private void ShowTitle()
    {
        Title.SetActive(true);
    }
}