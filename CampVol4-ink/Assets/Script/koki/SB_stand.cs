using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SB_stand : MonoBehaviour
{
    float count;
    [SerializeField] GameObject Botton;
    [SerializeField] Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(push);
     count = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        showsbutton();
    }

    void showsbutton(){
        if (count >= 3.0f){
            Invoke("Showbotton", 0.1f);
        }
    }

    private void Showbotton()
    {
        Botton.SetActive(true);
    }
    void push(){
        SceneManager.LoadScene("habstage");
    }
}
