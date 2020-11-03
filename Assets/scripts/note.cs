using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour {
    public float sec;

	// Use this for initialization
	 void Start () {
     
        Invoke("mainCS", sec);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void mainCS()
    {
        Application.LoadLevel(1);
        adManager.Instance.showBanner();
        adManager.Instance.showInterstitial();
        
        

    }
}
