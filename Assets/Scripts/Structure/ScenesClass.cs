using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesClass{
	//change Between rol Type
	public static void ShowHome(Rol rol){
        if (rol == Rol.MANAGER || rol == Rol.OWNER)
            SceneManager.LoadScene("HomeOwner");
        else
            SceneManager.LoadScene("HomeStaff");
	}

    public static void ShowPremios(Rol rol)
    {
        if (rol == Rol.OWNER)
            SceneManager.LoadScene("PremiosOwner");
        else if (rol == Rol.STAFF)
            SceneManager.LoadScene("PremiosStaff");
        else
            SceneManager.LoadScene("PremiosManager");
    }
    //Commons Scenes

    public static void ShowRanking(Rol rol){
        SceneManager.LoadScene("Ranking");
    }

	public static void ShowBeerTender(Rol rol){
        if (rol == Rol.STAFF)
            SceneManager.LoadScene("BeertenderStaff");
        else
            SceneManager.LoadScene("Beertender");
    }

	public static void ShowContacto(Rol rol){
        SceneManager.LoadScene("Contacto");
    }

}
