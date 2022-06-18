using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class StatusBar : MonoBehaviour
{
    [SerializeField] private GhostStatus status;
    [SerializeField] private Slider slider;
    void Start()
    {
        slider.value = 1;
    }
    
    public void UpdateHP()
    {
        slider.value = (float)status.hp / (float)status.maxhp;
    }
}
