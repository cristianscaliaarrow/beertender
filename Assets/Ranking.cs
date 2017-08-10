using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {

    public Image ico;
    public Text rankName;

    private void Awake()
    {
        ico = GameObject.Find(gameObject.name + "/Icon").GetComponent<Image>();
        rankName = GameObject.Find(gameObject.name + "/RankName").GetComponent<Text>();
    }

    public void SetRankingIcon()
    {

    }

}
