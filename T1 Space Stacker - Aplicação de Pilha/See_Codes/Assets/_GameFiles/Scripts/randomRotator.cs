using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRotator : MonoBehaviour {

    public float tumble;
    private Rigidbody rigid;
    // Use this for initialization
    void Start () {

        rigid = GetComponent<Rigidbody>();
        rigid.angularVelocity = Random.insideUnitSphere * tumble;
        
    }
	
	// Update is called once per frame
	void Update () {
       // transform.position = Random.insideUnitSphere * 5;

    }
}
