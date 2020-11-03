using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLevel : MonoBehaviour {

    public AudioClip clickClip;
    public AudioSource clickSource;
    

	// Use this for initialization
	void Start () {

        //if (FindObjectsOfType(GetType()).Length > 1)
        //{
        //    Destroy(gameObject);
        //}
        //DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update () {

		
	}

    public void mainLevelControl(string name)
    {

        Application.LoadLevel(name);
        adManager.Instance.showInterstitial();
        

    }

    public void singlePlayer(string name)
    {

        PlayerPrefs.SetInt("No.Players",1);
        Application.LoadLevel(name);
        adManager.Instance.showInterstitial();
    }
    
    public void multiPlayers(string name)
    {
        PlayerPrefs.SetInt("No.Players", -1);
        Application.LoadLevel(name);
        adManager.Instance.showInterstitial();
    }


   public void easy(string name)
    {
        PlayerPrefs.SetInt("difficulty", -1);
        Application.LoadLevel(name);
        adManager.Instance.showInterstitial();

    }

    public void medium(string name)
    {
        PlayerPrefs.SetInt("difficulty", 0);
        Application.LoadLevel(name);
        adManager.Instance.showInterstitial();
    }
    public void hard(string name)
    {
        PlayerPrefs.SetInt("difficulty", 1);
        Application.LoadLevel(name);
        adManager.Instance.showInterstitial();
    }

    public void clickPlay()
    {
        clickSource.clip = clickClip;
        clickSource.Play(); 
    }
}
