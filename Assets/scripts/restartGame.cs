using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartGame : MonoBehaviour {

    public float restartTime;
    bool restartNow = false;
    float resetTime;
    public GameObject ball;
    GameObject ballclone;
    int d;
    // Use this for initialization
    void Start()
    {
      ballclone = Instantiate(ball, transform.position, Quaternion.identity) as GameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        //if (restartNow && resetTime <= Time.time)
        //{

        //    ballclone = Instantiate(ball, transform.position, Quaternion.identity) as GameObject;
       
        //    //ball.transform.position = new Vector2(0, 0);
            
        //}

    }
    public void restartTheGame()
    {
        //restartNow = true;
        //resetTime = Time.time + restartTime;
        
        ballclone = Instantiate(ball, transform.position, Quaternion.identity) as GameObject;
    }

    public void win(int d)
    {
        PlayerPrefs.SetInt("winCode", d);
        Application.LoadLevel(4);
    }
}
