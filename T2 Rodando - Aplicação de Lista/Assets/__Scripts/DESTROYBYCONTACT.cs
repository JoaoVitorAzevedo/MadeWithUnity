using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYBYCONTACT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider other){
	
		Debug.Log ("Triggerou");
		Destroy (other.gameObject);

	}
}
