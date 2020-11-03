using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class adManager : MonoBehaviour {
    public string bannerId;
    public string InterstitialId;
    

	// Use this for initialization

        public static adManager Instance
    {
        set;
        get;
    }
	private void Start () {
        Instance = this;
        //if (FindObjectsOfType(GetType()).Length > 1)
        //{
        //    Destroy(gameObject);
        //}
        DontDestroyOnLoad(gameObject);
    


        Admob.Instance().initAdmob(bannerId,InterstitialId);
        Admob.Instance().loadInterstitial();
        Admob.Instance().removeBanner();

    }
	
	// Update is called once per frame
	void Update () {
      
	}
    public void showBanner()
    { 
        
   
            Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 0);
       
    }

    public void showInterstitial()
    {
        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
        }

    }
    public void removeBanner()
    {
        Admob.Instance().removeBanner();
    }
}
