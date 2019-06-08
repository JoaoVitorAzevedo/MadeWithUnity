using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elemento {

	public int valor;
	public int sceneId;
	public Image atualText;
	public string Textodir;
	public string Textoesq;
	public int guideNode;

	public Elemento(int v, string textoesq, string textodir, int sceneId){
		this.valor = v;
		this.Textodir = textodir;
		this.Textoesq = textoesq;
		this.sceneId = sceneId;

		
		
	}
	public Elemento(int v, int sceneId,int guide){
		this.valor = v;
		this.sceneId = sceneId;
		this.guideNode = guide;

	}
	public int getmyId(){
	
		return this.sceneId;
	}
	public int getGuideNode(){
		return  guideNode;
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public Elemento(int valor) {
		this.valor = valor;
	}

	public void setValor(int valor) {
		this.valor = valor;
	}

	public int getValor() {
		return valor;
	}

	}
