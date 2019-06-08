using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    Rigidbody rigid;
    public float speed;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
