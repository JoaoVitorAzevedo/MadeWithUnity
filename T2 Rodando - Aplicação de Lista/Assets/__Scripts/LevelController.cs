using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	public static LevelController instance;
	// Use this for initialization
	void Start () {
		instance = this;
		DontDestroyOnLoad(gameObject);
	//	Application.LoadLevel ("GamePlay"); 
		SceneManager.LoadScene ("GamePlay");
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
