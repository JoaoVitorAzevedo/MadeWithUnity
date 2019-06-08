using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTimer : MonoBehaviour {

    public float timerSpeed = 2f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("MethodName", timerSpeed, timerSpeed);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void MethodName()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2.0f);
        
    }
}
