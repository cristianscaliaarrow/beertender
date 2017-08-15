using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPremiosStaff : MonoBehaviour {

    public GameObject popUpCofirm;
    public GameObject popUpCongrats;
    public GameObject goPrize;
    public Transform parent;
    int count = 4;

	void Start () {
        for (int i = 0; i < count; i++)
        {
            bool readed = (i % 2 == 0);
            GameObject go = Instantiate(goPrize, parent);
            go.name = i + "";
            go.transform.localScale = Vector3.one;
            go.GetComponentInChildren<Button>().onClick.AddListener(() => OnPressedChange(go.name));
            //go.GetComponent<Text>().fontStyle = readed ? FontStyle.Normal : FontStyle.Bold;
            //go.GetComponent<Text>().color = readed ? Color.gray : Color.white;
        }
    }


    private void OnPressedChange(string name)
    {
        popUpCofirm.SetActive(true);
        print("Prize " + name);
    }

    public void BTN_SiguienteChange()
    {
        popUpCofirm.SetActive(false);
        popUpCongrats.SetActive(true);
    }

    public void BTN_CancelarChange()
    {
        popUpCofirm.SetActive(false);
    }

    public void BTN_CancelarCongrats()
    {
        popUpCongrats.SetActive(false);
    }
}
