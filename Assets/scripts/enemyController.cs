using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public GameObject ball;
    ballController BallController;
	void Start () {

     
	
	}

    // Update is called once per frame
    void Update() {
        //if (BallController.towardsPlayer == -1)
        //{

    }
    public void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "ball")
        {
            if (other.transform.position.y > transform.position.y)
            {
                transform.position = new Vector2(-7.0f, transform.position.y + 0.1f);
            }
            if (other.transform.position.y < transform.position.y)
            {
                transform.position = new Vector2(-7.0f, transform.position.y - 0.1f);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "ball")
        {
            if (other.transform.position.y > transform.position.y)
            {
                transform.position = new Vector2(-7.0f, transform.position.y + 0.1f);
            }
            if (other.transform.position.y < transform.position.y)
            {
                transform.position = new Vector2(-7.0f, transform.position.y - 0.1f);
            }
        }
    }

     public void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "ball")
        {
            if (0f > transform.position.y)
            {
                transform.position = new Vector2(-7.0f, transform.position.y + 0.1f);
            }
            if (0f < transform.position.y)
            {
                transform.position = new Vector2(-7.0f, transform.position.y - 0.1f);
            }
        }
        //}
        //else
        //{
        //    if (0f > transform.position.y)
        //    {
        //        transform.position = new Vector2(-7.7f, transform.position.y + 0.1f);
        //    }
        //    if (0f < transform.position.y)
        //    {
        //        transform.position = new Vector2(-7.7f, transform.position.y - 0.1f);
        //    }

        //}
    }


}
