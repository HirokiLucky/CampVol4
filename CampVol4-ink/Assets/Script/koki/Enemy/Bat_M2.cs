using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;


public class Bat_M2 : MonoBehaviour
{
    [SerializeField] private BatStatus status;
    [SerializeField] private Slider hpslider;
    [SerializeField]
    private GameObject HPUI;
    
    
    void Start()
    {
        status.hp = 50;
        hpslider.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHPValue();
        if (status.hp <= 0) {
            //　HP表示用UIを非表示にする
            HideStatusUI();
        }
    }

    public void HideStatusUI() {
        HPUI.SetActive(false);
    }
 

    public void UpdateHPValue() {
        hpslider.value = (float)status.hp/ (float)status.maxhp;
    }
}