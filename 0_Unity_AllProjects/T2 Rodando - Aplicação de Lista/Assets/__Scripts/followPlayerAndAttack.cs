using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerAndAttack : MonoBehaviour {


	public GameObject player;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player.transform);
		//transform.forward;
		transform.Translate(4.5f * (Vector3.forward  * Time.deltaTime));
		
	}


	/* void OnCollisionEnter(Collision other){
		Debug.Log ("MOn Collisiom Enter");
		Destroy (this.gameObject);
	
	
	} */
	void OnTriggerEnter(Collider other){
	//	Debug.Log ("On trigger Enterr");
		Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		Destroy (this.gameObject);


	}
}
