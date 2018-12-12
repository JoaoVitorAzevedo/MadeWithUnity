using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playar : MonoBehaviour {


	AudioSource audio;

	// Use this for initialization
	void Start () {
		
		AudioSource audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickmen(){

		audio.Play ();
		audio.Play();
	}
}
