using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//gameOver

public class PBtGO : MonoBehaviour
{
    [SerializeField] Button btn;

    [SerializeField] private unitychanStatus unitychanStatus;
    
    // Start is called before the first frame update
    void Start(){
        btn.onClick.AddListener(push);
    }

    // Update is called once per frame
    void push(){
        Gamesystem.isClear1 = false;
        Gamesystem.isClear2= false;
        Gamesystem.isClear3= false;
        unitychanStatus.hp = 10;
        unitychanStatus.life = 100;
        unitychanStatus.star = 0;
        SceneManager.LoadScene("Stand_koki");
    }
}
