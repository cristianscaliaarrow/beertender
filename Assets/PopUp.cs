using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public Text txt;
    public static PopUp instance;

    private void Awake()
    {
        instance = this;
        txt = GameObject.Find(name + "/Text").GetComponent<Text>();
        BTN_CloseMe();
    }

    public void BTN_CloseMe()
    {
        instance.gameObject.SetActive(false);
    }

    public static void ShowMessage(string msg)
    {
        instance.gameObject.SetActive(true);
        instance.txt.text = msg;
    }

}

