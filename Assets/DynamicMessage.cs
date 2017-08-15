using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DynamicMessage : MonoBehaviour {

    public GameObject prefabText;
    public Transform parent;

    public static int noReaded = 0;
    public static ListMessages listMessages;
    private static string filePrevMessages = "previousMessages.txt";

    void Start () {
        ReadPreviousMessages();
        CreateList();
    }

    public static void ReadPreviousMessages()
    {
        
        if (File.Exists(filePrevMessages))
        {
            String prevMessagesJson = File.ReadAllText(filePrevMessages);
            listMessages = JsonUtility.FromJson<ListMessages>(prevMessagesJson);
        }else if(listMessages == null)
        {
            listMessages = new ListMessages();
            noReaded = 0;
            for (int i = 0; i < 4; i++)
            {
                bool readed = i != 0 && i != 1;
                if (!readed) noReaded++;
                listMessages.messages.Add(new Message("Hola",readed, i));
            }
        }

    }

    private string FixJson(string keyParent, string data)
    {
        return string.Format("{{ \"{0}\": {1}}}", keyParent, data);
    }

    public void ShowPopUpMessage(string name)
    {
        print("PRESSED !  " + name);
        foreach (var item in listMessages.messages)
        {
            if(item.id == int.Parse(name))
            {
                item.readed = true;
            }
        }
        ClearList();
        CreateList();
        EventManager.DispatchEvent(EventId.UpdatePendingMessages);
    }

    public void ClearList()
    {
        noReaded = 0;
        foreach (Transform item in parent)
        {
            Destroy(item.gameObject);
        }
    }

    public void CreateList()
    {
        for (int i = 0; i < listMessages.messages.Count; i++)
        {
            bool readed = listMessages.messages[i].readed;
            if (!readed) noReaded++;
            GameObject go = Instantiate(prefabText, parent);
            go.name = i + "";
            go.transform.localScale = Vector3.one;
            go.GetComponent<Button>().onClick.AddListener(() => ShowPopUpMessage(go.name));
            go.GetComponent<Text>().fontStyle = readed ? FontStyle.Normal : FontStyle.Bold;
            go.GetComponent<Text>().color = readed ? Color.gray : Color.white;
            go.GetComponent<Text>().text = listMessages.messages[i].message;
        }
    }
}


