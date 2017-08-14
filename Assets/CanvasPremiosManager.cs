using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPremiosManager : MonoBehaviour {
    public GameObject staticPrize;
    public GameObject dinamycPrize;

    public void BTN_ShowPrizes()
    {
        staticPrize.SetActive(false);
        dinamycPrize.SetActive(true);
    }

}
