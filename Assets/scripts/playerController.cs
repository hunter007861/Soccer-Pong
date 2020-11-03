using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    
    public Rigidbody2D myRB;
    private Vector3 pos;
	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody2D>();
        adManager.Instance.removeBanner();

    }
    //Update is called once per frame
    void FixedUpdate()
    {
        Touch myTouch = Input.GetTouch(0);

        Touch[] myTouches = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
            //Do something with the touches

            if (Input.GetTouch(i).position.x > Screen.width / 2)
                pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y, 5));

            myRB.transform.position = new Vector3(7, pos.y, 0);
        }

    }
}
