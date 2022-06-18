using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Testbutton : MonoBehaviour
{
    [SerializeField] Button btn;
    // Start is called before the first frame update
    void Start(){
        Debug.Log ("debug comment");
        btn.onClick.AddListener(push);
    }

    // Update is called once per frame
    void push(){
        Debug.Log ("push");
        SceneManager.LoadScene("habstage");
        Debug.Log ("push");
    }
}