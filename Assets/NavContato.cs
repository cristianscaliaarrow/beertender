using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavContato : MonoBehaviour {

    public Image contacto;
    public Image mensaje;

    public float scaleOff;
    public float scaleOn;

    public Sprite contactoOn;
    public Sprite contactoOff;

    public Sprite mensajeOn;
    public Sprite mensajeOff;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void BTN_Contacto()
    {
        contacto.sprite = contactoOn;
        contacto.transform.localScale = Vector3.one* scaleOn;
        mensaje.sprite = mensajeOff;
        mensaje.transform.localScale = Vector3.one * scaleOff;
    }

    public void BTN_Mensaje()
    {
        contacto.sprite = contactoOff;
        contacto.transform.localScale = Vector3.one * scaleOff;
        mensaje.sprite = mensajeOn;
        mensaje.transform.localScale = Vector3.one * scaleOn;

    }
}
