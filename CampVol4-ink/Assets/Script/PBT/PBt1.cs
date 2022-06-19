using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//YouDie
public class PBt1 : MonoBehaviour
{
    [SerializeField] Button btn;
    // Start is called before the first frame update
    void Start(){
        btn.onClick.AddListener(push);
    }

    // Update is called once per frame
    void push(){
        SceneManager.LoadScene("nagaiAria");
    }
}
