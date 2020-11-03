using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cleaner : MonoBehaviour {

    public restartGame theGameManager;
    public Text Score;
    public int a;
    public int c;
    // Use this for initialization
    void Start()
    {
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    { 
          Destroy(other.gameObject);
          a += 1;
        if (a <= 5)
        {
            Score.text = a.ToString();
            theGameManager.restartTheGame();
        }
        else
        {
            theGameManager.win(c);

                  
                
        }


    }
}
