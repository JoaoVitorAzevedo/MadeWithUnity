using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LerAlturadoChar : MonoBehaviour {

	public Transform personagem;
	 Text textodaInterface;

	// Use this for initialization
	void Start () {

		textodaInterface = GetComponent<Text>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
	//	Debug.Log (personagem.position.y);
		textodaInterface.text = Mathf.RoundToInt(personagem.position.y).ToString();
	}
}
