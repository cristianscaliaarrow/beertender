using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour {
    public GoogleAnalyticsV4 googleAnalytics;
	// Use this for initialization
	void Start () {
        googleAnalytics.StartSession();
        googleAnalytics.LogScreen("MAIN NAVEGATONR");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
