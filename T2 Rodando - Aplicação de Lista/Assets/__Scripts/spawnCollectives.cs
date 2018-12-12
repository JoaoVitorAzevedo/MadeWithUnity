using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCollectives : MonoBehaviour {

	public GameObject[] collects;
	public Vector3 spawnValues;
	public int qtdSpawned;

	public Player thePlayer;

	// Use this for initialization
	void Start () {
		thePlayer = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();






		//GameObject coletavel = collects [Random.Range (0, collects.Length)];

		string[] myname = new string[6];
		myname[0] = "Torus"; 
		myname[1] = "Green"; 
		myname[2] = "Red"; 
		myname[3] = "Lime"; 
		myname[4] = "Bat"; 
		myname[5] = "Phantom";



		for (int i = 0; i < qtdSpawned; i++) {
			Vector3 spawnPos = new Vector3(Random.Range(15, 200),
				transform.position.y, Random.Range(50, 230));
			int n; n = Random.Range (0, collects.Length);
			if (n == 0) {
			thePlayer.listaDoPlayer.inserir (0,"Torus"); // Torus
				thePlayer.qtdTorus++;
				
			}
			if (n == 1) {
				thePlayer.listaDoPlayer.inserir (1,"Green"); // Green
				thePlayer.qtdGreen++;

			}
			if (n == 2) {
				thePlayer.listaDoPlayer.inserir (2,"Red"); // Red
				thePlayer.qtdRed++;
			}
			if (n == 3) {
				thePlayer.listaDoPlayer.inserir (3,"Lime"); // lime
				thePlayer.qtdLime++;

			}
			if (n == 4) {
				thePlayer.listaDoPlayer.inserir (4,"Bat"); //bat
				thePlayer.qtdBat++;

			}
			if (n == 5) {
				thePlayer.listaDoPlayer.inserir (5,"Phantom"); //phantom
				thePlayer.qtdPhantom++;

			}

			Instantiate(collects[n], spawnPos,Quaternion.identity);
			Debug.Log("Instancieii um : " + myname[n]);

		}
		// Instantiate(coletavel, spawnPos, spawnRot);


	}

	// Update is called once per frame
	void FixedUpdate () {
		//wait = Time.deltaTime;


	}
	 void OnCollisionEnter(Collision other){
		Debug.Log ("Alguem foi destruido");
		Destroy (other.gameObject);

	
	}

}
