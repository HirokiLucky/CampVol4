using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menutext : MonoBehaviour
{
    [SerializeField] Button btn;
    // Start is called before the first frame update
    void Start(){
        btn.onClick.AddListener(push);
    }

    // Update is called once per frame
    void push(){
        //処理について
        Debug.Log("ボタンが押されました");
        SceneManager.LoadScene("habstage");
    }
}
