using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStampTimer : MonoBehaviour {

    private float timerSpeed = 2.0f;
    private float lastTimeStamp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time - lastTimeStamp >= timerSpeed)
        {
            lastTimeStamp = Time.time;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2.0f);
        }
		
	}
}
