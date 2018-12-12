using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meniController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey) { 
			Screen.lockCursor = false;
		}


	}

	public void ChamaSelecaoDeCena(){
		SceneManager.LoadScene ("SelecionaFase");

	}

	public void chamaMeni(){
		SceneManager.LoadScene ("Meni");
	}

	public void comoJugarButton(){
		SceneManager.LoadScene ("comoJugar");
	}

	public void callFase1(){
		SceneManager.LoadScene ("forest2");


	}

}
