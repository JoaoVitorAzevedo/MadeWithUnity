using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

    public float velocity = 10.0f;
    public float horizontalAxis;
    public Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        

		
	}
	
	// Update is called once per frame
	void Update () {
        horizontalAxis = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2 (velocity * horizontalAxis, 0);

    }
}
