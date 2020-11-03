using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeApplication : MonoBehaviour {

    public Canvas exitPromt;
    public CanvasGroup menu;


	// Use this for initialization
	void Start () {

        exitPromt =exitPromt.GetComponent<Canvas>();
        menu = menu.GetComponent<CanvasGroup>();
        exitPromt.enabled = false;
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void exitPromptEnable()
    {
        exitPromt.enabled = true;
        menu.interactable = false;
      
    }

    public void onPressNo()
    {
        exitPromt.enabled = false;
        menu.interactable = true;
      
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
