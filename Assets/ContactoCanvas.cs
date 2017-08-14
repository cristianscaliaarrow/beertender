using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactoCanvas : MonoBehaviour {

    public GameObject popUp;

    public void BTN_Enviar(bool boolean)
    {
        popUp.SetActive(boolean);
    }

}
