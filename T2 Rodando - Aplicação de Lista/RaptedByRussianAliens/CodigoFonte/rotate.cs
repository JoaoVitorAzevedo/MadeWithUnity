using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {


	public Vector3 insertHereTheRotationValues;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (insertHereTheRotationValues);
		
	}
}
