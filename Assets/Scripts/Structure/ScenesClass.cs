using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesClass{
	//change Between rol Type
	public static void ShowHome(Rol rol){
        SceneManager.LoadScene("HomeOwner");
	}

    public static void ShowPremios(Rol rol)
    {
        SceneManager.LoadScene("PremiosOwner");
    }
    //Commons Scenes

    public static void ShowRanking(Rol rol){
        SceneManager.LoadScene("Ranking");
    }

	public static void ShowBeerTender(Rol rol){
        SceneManager.LoadScene("Beertender");
    }

	public static void ShowContacto(Rol rol){
        SceneManager.LoadScene("Contacto");
    }

}
