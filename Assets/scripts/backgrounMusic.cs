using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgrounMusic : MonoBehaviour {

    public AudioClip backgroundClip;
    public AudioSource backgroundAs;

	// Use this for initialization
	void Start () {

        Invoke("backgroundSound", 4f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void backgroundSound()
    {
        backgroundAs.clip = backgroundClip;
        backgroundAs.Play();
    }

}
