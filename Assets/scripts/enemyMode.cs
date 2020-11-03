using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMode : MonoBehaviour {
    public int p;
    public GameObject singlePlayer;
    public GameObject MultiPlayer;
    public GameObject easy;
    public GameObject medium;
    public GameObject hard;
    public int d;
	// Use this for initialization
	void Start () {
        p = PlayerPrefs.GetInt("No.Players");
        d = PlayerPrefs.GetInt("difficulty");
        if (p > 0)
        {
            singlePlayer.gameObject.SetActive(true);
        }
        else if(p < 0)
        {
            MultiPlayer.gameObject.SetActive(true);
          
        }
        if (d < 0)
        {
            easy.gameObject.SetActive(true);

        }
        else if (d == 0)
        {
            medium.gameObject.SetActive(true);
        }
        else if (d > 0)
        {
            hard.gameObject.SetActive(true);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
