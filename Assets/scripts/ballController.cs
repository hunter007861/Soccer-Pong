using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

    int invert;
    public int towardsPlayer = 1;
    public Rigidbody2D ballRB;
    float x;
    public AudioClip ballHit;
    public AudioSource hitAS;
    float q;

 
	// Use this for initialization

	public void Start () {

        //adManager.Instance.removeBanner();
        ballRB = GetComponent<Rigidbody2D>();
        invert = 1;
        towardsPlayer = 1;
        x = 4.0f;
        transform.position = new Vector2(0, 0);
        q = Random.Range(1, 4);
        
        Invoke("ballStart", 3f);
      
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "border")
        {
            //invert = invert * -1;
            //ballRB.velocity = new Vector2(x * towardsPlayer, ballRB.velocity.y /** invert*/);
            hitAS.clip = ballHit;
            hitAS.Play();

        }
        else
        if (other.gameObject.name == "player")
        {

            towardsPlayer = towardsPlayer * -1;
            ballRB.velocity = new Vector2(x * towardsPlayer,ballRB.velocity.y);
            x++;
            hitAS.clip = ballHit;
            hitAS.Play();

        }
        else if (other.gameObject.tag == "enemy")
        {
            //invert = invert * 1;
            //towardsPlayer = towardsPlayer * -1 ;
            //ballRB.velocity = new Vector2(x , ballRB.velocity.y/* *invert */);
            hitAS.clip = ballHit;
            hitAS.Play();


        }

     
    }

     public void ballStart()
    {
        if (q == 1)
        {
            ballRB.velocity = new Vector2(4.0f, 5.0f);
        }
        else if (q == 2)
        {
            ballRB.velocity = new Vector2(-4.0f, 5.0f);
        }
        else if (q == 3)
        {
            ballRB.velocity = new Vector2(-4.0f, -5.0f);
        }
        else if (q == 4)
        {
            ballRB.velocity = new Vector2(4.0f,-5.0f);
        }



    }
}
