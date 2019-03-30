using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBall : MonoBehaviour {


	public Transform theball;
	public Transform me;
	// Use this for initialization
	void Start () {
	//	this.transform.LookAt (theball);
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (theball);
		transform.SetPositionAndRotation (new Vector3 (theball.position.x, theball.position.y + 6, theball.position.z - 10), Quaternion.identity);
		//transform.position.x = theball.position.x;
		//transform.position.z = theball.position.z;


	}
}
