using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeThePlayer : MonoBehaviour {

	public int damage;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			
			Instantiate (explosion);
			Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Debug.Log ("mandei destruir o player em 5 segundos e instanciei a explosao ja");
			//Destroy (other.gameObject, 2);
			// decrease player life
			Player dio = other.gameObject.GetComponent<Player>();

			dio.getDamage (damage);
			Destroy (this.gameObject);

		}
	
	}

}
