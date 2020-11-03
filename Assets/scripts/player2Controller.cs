using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Controller : MonoBehaviour {

    private Vector3 pos;
    public Rigidbody2D myRB;

    // Use this for initialization
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

    }
    //Update is called once per frame
    void FixedUpdate()
    {
        Touch myTouch = Input.GetTouch(0);

        Touch[] myTouches = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
            //Do something with the touches

            if (Input.GetTouch(i).position.x < Screen.width / 2)
                pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y, 5));

            myRB.transform.position = new Vector3(-7, pos.y, 0);
        }
    }
}
