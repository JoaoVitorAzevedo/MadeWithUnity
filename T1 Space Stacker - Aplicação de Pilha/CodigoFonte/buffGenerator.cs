using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffGenerator : MonoBehaviour {

    public GameObject[] buffs;
    public float wait, nextSpawn; 
	// Use this for initialization
	void Start () {
         nextSpawn = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //wait = Time.deltaTime;
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + wait;
            Instantiate(buffs[Random.Range(0, buffs.Length)], transform.position, transform.rotation);
            
        }
        
		
	}
}
