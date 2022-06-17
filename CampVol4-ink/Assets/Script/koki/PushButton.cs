using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PushButton : MonoBehaviour
{
    [SerializeField] Button btn;
    // Start is called before the first frame update
    void Start(){
        btn.onClick.AddListener(push);
    }

    // Update is called once per frame
    void push(){
        Debug.Log("ボタンが押されました");
        SceneManager.LoadScene("koki_tutrials");
    }
}
