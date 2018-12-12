using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista {

	private Node inicio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Lista(){
		// criando a lista vazia
		this.inicio = null;

	}

	public void inserir(int elemento, string nome)
	{
		// preciso criar um novo nó!
		Node novoNo = new Node ();
		novoNo.setElemento (elemento);
		novoNo.setNome (nome);// 
		novoNo.setProximo(null); // depois dele n vem ngmm

		if(inicio == null){ // vai ser o primeiro no?
			inicio = novoNo;		 

		} else { // ja tem gente na lista;
			Node aux;
			aux = inicio; 
			while (aux.getProximo() != null)
			{
				aux = aux.getProximo();
			}
			aux.setProximo (novoNo);
			
		}



	}

	public int contarporCodigo(int codigo){
		// uso interno
		// 1 = torus, 2 = green, 3 = red, 4 = lime, 5 = bat, 6 = phantom
		/*
		Lista aux = this; int qtd = 0;
		while(aux.isEmpty() == false){
		int e = aux.retirar();
			if (e == codigo) {
				qtd++;
				
			}
				
			}
		return qtd; */

		Node aux = inicio; int qtd = 0;
		while (aux != null) {
			
			if (aux.getElemento() == codigo) {
				qtd++;
			}
			aux = aux.getProximo();			
		
		
		}
	
		return qtd; 
	}


	public int retirar()
	{
		// esse metodo considera que a lista sempre tem elementos
		// alguem na aplicacao precisa( antes de remover) , testar se a lista esta vaziaaaaa
		Node aux = inicio;
		int elemento = aux.getElemento ();
		inicio = aux.getProximo();
		return elemento;

		// O GarbageCollector vai se virar pra desalocar memoria

	}

	public void retirarPorCodigo(int cod){
		Node aux = inicio; Node anterior = null;
		while(aux != null){
			if (aux.getElemento () == cod) {
				if (anterior == null) {
					inicio = inicio.getProximo ();
					aux = null;
					break;
					//anterior = null; aux = null;
				} else {

					anterior.setProximo (aux.getProximo ());
					aux = null;
					anterior = null;
					break;
				}
			} // Atencao: a lista não foi desenvolvida pra tratar casos com 1 ou 2 elementos, pois isso significa que o player ja está morto
			// muitos inimigos ja foram "destruidos".

			else {
				anterior = aux;
				aux = aux.getProximo ();

			}
}


	}
	public void listar()
	{
		Debug.Log ("...Listando...");

		if (inicio == null) {
			Debug.Log ("Nada a exibir: a lista está vazia");
		
		} else {
			Node aux = inicio;
			while (aux != null) {
				Debug.Log("Elemento visto "+ aux.getElemento());
				aux = aux.getProximo ();
			
			}
		}
	
	
	}

	public bool isEmpty(){
		return (this.inicio == null);
	}
}
