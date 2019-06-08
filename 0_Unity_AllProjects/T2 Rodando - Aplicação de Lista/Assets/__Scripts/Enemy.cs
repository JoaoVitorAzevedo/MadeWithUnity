using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject explosion;
	public int damage;
	public GameObject player;
	public float moveSpeed;
	public bool isAnimated;

	public int codigo; // diferente para cada inimigo ou item. 

	//public int codigo;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isAnimated) {
			this.followAttack();
		}
	}

	void followAttack(){
		transform.LookAt (player.transform);
		transform.Translate( moveSpeed * (Vector3.forward * Time.deltaTime));
	}

	 void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {			
			Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Debug.Log ("OnTriggerEnter do enemy no player");
			//Destroy (other.gameObject, 2);
			// decrease player life

			Player dio = other.gameObject.GetComponent<Player>();
			dio.getDamage (damage); 
			Debug.Log ("Tirei " + damage + " de vida do player");
			dio.listaDoPlayer.retirarPorCodigo (codigo);
			Destroy (this.gameObject);

		}


	} 

/* 	void OnCollisionEnter(Collision ot){
	


		if (ot.gameObject.tag == "Player") {	
			Debug.Log ("Colidiu sem trigger com player");
			Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Debug.Log ("OnCollision do enemy no player");
			//Destroy (other.gameObject, 2);
			// decrease player life

			Player dio = ot.gameObject.GetComponent<Player>();
			dio.getDamage (damage); Debug.Log ("Tirei " + damage + " de vida do player");
			Destroy (this.gameObject);

		}

	} */
}
