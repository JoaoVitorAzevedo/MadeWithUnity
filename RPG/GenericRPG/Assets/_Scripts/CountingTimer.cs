using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingTimer : MonoBehaviour {

    private float timerSpeed = 2f;
    private float elapsed;

	// Use this for initialization
	void Start () {
        elapsed = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
        elapsed += Time.deltaTime;
        if(elapsed >= timerSpeed)
        {
            elapsed = 0f;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2.0f);
        }

		
	}
}
