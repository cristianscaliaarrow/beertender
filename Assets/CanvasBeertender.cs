using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBeertender : MonoBehaviour {

    public GameObject groupBeerTender;
    public GameObject groupBases;
    public GameObject groupMarca;
    public Toggle toggleAceptar;
    public void BTN_BeerTender()
    {
        ActiveGroup(BId.BeerTender);
    }

    public void BTN_BasesYCondi()
    {
        ActiveGroup(BId.Bases);
    }

    public void BTN_ConoceMarca()
    {
        ActiveGroup(BId.Marca);
    }

    private void ActiveGroup(BId bid)
    {
        groupBeerTender.SetActive(bid == BId.BeerTender);
        groupBases.SetActive(bid == BId.Bases);
        groupMarca.SetActive(bid == BId.Marca);
    }

    public void BTN_AceptarTerminos()
    {
        if (toggleAceptar.isOn)
        {
            PopUp.ShowMessage("OK! HAS Aceptado!");
        }else
        {
            PopUp.ShowMessage("NO has Aceptado los terminos y condiciones!");
        }
    }
}

public enum BId
{
    BeerTender,Marca,Bases
}
