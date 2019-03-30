using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIn : MonoBehaviour {

	public float timeToDestroy;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, timeToDestroy);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
