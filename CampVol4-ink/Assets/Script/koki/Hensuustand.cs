using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hensuustand : MonoBehaviour
{
    public TextMeshProUGUI Text;
    [SerializeField] private unitychanStatus status;
    //Start is called before the first frame update
    void Start()
    {
        //GameObject player = GameObject.FindWithTag("Player")
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = string.Format("sum "+status.star);
    }
}
