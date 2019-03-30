using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node{


	private int elemento;
	private Node next;
	private string nome;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int getElemento(){
		return this.elemento;
	}
	public void setElemento(int elemento){
		this.elemento = elemento;

	}
	public void setNome(string nome){
		this.nome = nome;

	}
	public void setProximo(Node proximo){
		this.next = proximo;
	}
	public Node getProximo(){
		return this.next;
	
	}


}
