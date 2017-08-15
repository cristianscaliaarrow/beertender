using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeOwnerManager : MonoBehaviour {
    public GameObject PopUp;

	public void ShowHistory(bool boolean)
    {
        PopUp.SetActive(boolean);
    }
}
