using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addCoguGreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			Player pl = other.gameObject.GetComponent<Player>();
			pl.qtdGreen++;
		}


	}
}
