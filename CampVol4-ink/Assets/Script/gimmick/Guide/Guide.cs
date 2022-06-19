using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Guide : MonoBehaviour
{

    public string message;
    public GameObject messagePref;

    private GameObject canvas;
    private GameObject messageUI;
    private Vector3 targetPos = new Vector3(700, 250, 0);
    private float fadein_x = 100;
    private float fadeout_x = 300;

    void Start()
    {
        canvas = GameObject.Find("Canvas");
    }

    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (!messageUI)
            {
                // メッセージ表示用Ui生成
                messageUI = Instantiate(messagePref) as GameObject;
                messageUI.transform.SetParent(canvas.transform, false);

                // メッセージ設定
                TextMeshProUGUI messageUIText = messageUI.transform.Find("Guide").GetComponent<TextMeshProUGUI>();
                messageUIText.text = message;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            messageUI.transform.position = Vector3.MoveTowards(messageUI.transform.position, targetPos, Time.deltaTime * 1000);
        }
    }

    public void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (messageUI)
            {
                Destroy(messageUI);
            }
        }
    }
}