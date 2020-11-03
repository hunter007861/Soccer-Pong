using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winnerScript : MonoBehaviour {

    public restartGame menuController;
    public int a;
    public Text Red;
    public Text Blue;


	// Use this for initialization
	void Start() {
        a = PlayerPrefs.GetInt("winCode");
        if (a == 1)
        {
            Animator redWinAnimator = Red.GetComponent<Animator>();
            redWinAnimator.SetTrigger("showText");
        }
        else
        if(a > 1)
        {
            Animator redWinAnimator = Blue.GetComponent<Animator>();
            redWinAnimator.SetTrigger("showText");
        }
    }
	
	// Update is called once per frame
	void Update () {
     
    }
}
