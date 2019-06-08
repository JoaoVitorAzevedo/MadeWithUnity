using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    Rigidbody2D rigid;
    public Vector2 velocity;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        rigid.AddForce(velocity);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
