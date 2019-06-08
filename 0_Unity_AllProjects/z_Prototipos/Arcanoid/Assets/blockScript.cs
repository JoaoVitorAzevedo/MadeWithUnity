using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScript : MonoBehaviour {

    public Rigidbody2D rigid;
    public BoxCollider2D box;
	// Use this for initialization
	void Start () {

            rigid = GetComponent<Rigidbody2D>();
            box = GetComponent<BoxCollider2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* GameObject collider = collision.collider.gameObject;
        GameObject.Destroy(collider); */
        rigid.constraints = new RigidbodyConstraints2D();
        box.isTrigger = true;
        
    }
}
