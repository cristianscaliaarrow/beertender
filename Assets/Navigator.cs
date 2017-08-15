using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigator : MonoBehaviour {
	public ScreenId screen;

	public Button rankin;
	public Sprite rankingOn;
	public Sprite rankingOff;

	public Button premios;
	public Sprite premiosOn;
	public Sprite premiosOff;

	public Button beertenders;
	public Sprite beertendersOn;
	public Sprite beertendersOff;

	public Button contacto;
	public Sprite contactoOn;
	public Sprite contactoOff;

    public GameObject pendingMessages;


	public void Awake(){
		contacto.image.sprite = screen == ScreenId.CONTACTO? contactoOn:contactoOff;
		premios.image.sprite = screen == ScreenId.PREMIOS? premiosOn:premiosOff;
		beertenders.image.sprite = screen == ScreenId.BEERTENDERS? beertendersOn:beertendersOff;
		rankin.image.sprite = screen == ScreenId.RANKING? rankingOn:rankingOff;
        ShowPendingMessages();
        EventManager.AddEvent(EventId.UpdatePendingMessages, ShowPendingMessages);
	}

    private void ShowPendingMessages()
    {
        DynamicMessage.ReadPreviousMessages();
        pendingMessages.SetActive(DynamicMessage.noReaded != 0);
        pendingMessages.GetComponentInChildren<Text>().text = DynamicMessage.noReaded + "";
    }

    public void BTN_Rankin(){
		ScenesClass.ShowRanking (User.currentRol);
	}

	public void BTN_Premios(){
		ScenesClass.ShowPremios (User.currentRol);
	}

	public void BTN_BeerTenders(){
		ScenesClass.ShowBeerTender(User.currentRol);
	}

	public void BTN_Contacto(){
		ScenesClass.ShowContacto(User.currentRol);
	}

    public void BTN_Home()
    {
        ScenesClass.ShowHome(User.currentRol);
    }

}


public enum ScreenId{
	HOME,RANKING,PREMIOS,BEERTENDERS,CONTACTO
}