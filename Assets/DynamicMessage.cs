using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicMessage : MonoBehaviour {

    public GameObject prefabText;
    public Transform parent;

    int count = 5;
	void Start () {
        for (int i = 0; i < count; i++)
        {
            bool readed = (i % 2 == 0);
            GameObject go = Instantiate(prefabText,parent);
            go.name = i+"";
            go.transform.localScale = Vector3.one;
            go.GetComponent<Button>().onClick.AddListener(() => ShowPopUpMessage(go.name));
            go.GetComponent<Text>().fontStyle = readed ? FontStyle.Normal : FontStyle.Bold;
            go.GetComponent<Text>().fontSize = readed ? 32 : 38;
        }
	}

    public void ShowPopUpMessage(string name)
    {
        print("PRESSED !  " + name);
    }
}
