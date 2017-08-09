using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

	public Rol type;
	public InputField usuario;
	public InputField password;

	public void BTN_GenerateKey(){
		print ("Generate key");
	}

	public void BTN_Connect(){
		bool userOk = ExecuteLogin ();

		if (userOk) {
			print ("Go To Next Stage!");
		} else {
			print ("Pass Bad");
		}

	}

	public bool ExecuteLogin(){
		return usuario.text.ToLower() == "cristian";
	}
}
