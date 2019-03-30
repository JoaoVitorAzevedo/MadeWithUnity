using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arvore
{
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	private Elemento ele;
	private Arvore dir;
	private Arvore esq;

	public Arvore() {
		this.ele = null;
		this.dir = null;
		this.esq = null;
	}

	public void free(Arvore arvre){
		
		int i;
		for (i = 0; i < 120; i++) {
			Elemento el = new Elemento (i, 0,-1); // remove todos os indices, limpando a arvore))

			if (arvre.getEsquerda () != null) {
				arvre.free (arvre.getEsquerda ());
			}

			if (arvre.getDireita () != null) {
				arvre.free (arvre.getDireita ());
			}

			arvre.addAsCria(remover(el));
		}

		Debug.Log ("Esvaziei a arvore");
	}


	public void addAsCria(Arvore copiandoEssa){



			if(copiandoEssa.isEmpty() == false){ 
			Elemento ad = new Elemento (copiandoEssa.getElemento ().getValor (), copiandoEssa.getElemento ().getmyId (),copiandoEssa.getElemento().getGuideNode());
			this.inserir (ad);
				
			if (copiandoEssa.getEsquerda () != null) {
				addAsCria (copiandoEssa.getEsquerda ());
				//Debug.Log ("copiandoessa.getEsquerda , afinal  getEsquerda nao é null: code - " + copiandoEssa.getEsquerda().getElemento().getmyId());
			}

			if (copiandoEssa.getDireita () != null) {
				addAsCria (copiandoEssa.getDireita ());
			//	Debug.Log ("copiandoessa.getDireita , afinal  getDireita nao é null: code - " + copiandoEssa.getDireita	().getElemento().getmyId());

			}

			}
		}


		

		//Debug.Log ("addAsCria CHamado"); Debug.Log ("O ad as crias de + " + this.getElemento().getmyId () + "ID");

			

		
		


		

		


		
		
	
		



	public Arvore remover(Elemento elem){
		//retorna uma arvore sem a referencia para o nó removido, e o Garbage Collector que se vire pra jogar isso fora ;) 	
			//primeiro caso: achei o elemento
		if(this.ele.getValor() == elem.getValor()){
			// caso 1: o elemento é um no folha
			if(this.dir == null && this.esq == null)
				return null;
			else{
				if(this.esq != null && this.dir == null) {
					return this.esq; //o nó onde achei elem só tem filhos à esquerda
				} else if(this.dir != null && this.esq == null){
					return this.dir;             //o nó onde achei elem só tem filhos à direita
				}// caso 4 : filhos à esquerda e à direita
				else{ // usar o maior dentre os menores
					Arvore aux = this.esq;
					while(aux.dir != null){
						aux = aux.dir;
					}
					//troco os elementos da arvore
					this.ele = aux.getElemento(); // o nó atual( o que tinha elem recebe o elemento do aux
					aux.setElemento(elem);    // insiro no nó "folha" la embaixo o elemento a ser eliminado
					this.esq = esq.remover(elem);


					// .

				}
			}


		}
		else if(this.ele.getValor() > elem.getValor()){

			//if(this.esq != null) //
				this.esq = this.esq.remover(elem);				
			// delega pra subarvore da esquerda
		}
		else if(this.ele.getValor() < elem.getValor()){

			//if(this.dir != null) //
				this.dir = this.dir.remover(elem);
			// delega pra subarvore da direita
		}
		//  return null; 
		return this;
	}







	public void preOrdem(){
		if(!isEmpty()){ 
			Debug.Log(" "+ this.ele.getValor());
			if(this.esq != null)
				this.esq.preOrdem();
			if(this.dir != null)
				this.dir.preOrdem();


		}
	}
	public void inOrdem(){
		if(!isEmpty()){ 
			if(this.esq != null) {
				this.esq.inOrdem();
			}

			Debug.Log(" "+ this.ele.getValor());

			if(this.dir != null) {
				this.dir.inOrdem(); 
			}

		}

	}
	public void posOrdem(){
		if(!isEmpty()){ 
			if(this.esq != null)
				this.esq.posOrdem();

			if(this.dir != null)
				this.dir.posOrdem();

			Debug.Log(" "+ this.ele.getValor());

		}
	}

	public Arvore(Elemento elem) {
		this.ele = elem;
		this.dir = null;
		this.esq = null;
		//  Debug.Log("criei a arvore com o elemento " + elem.getValor());
	}


	public bool busca(int valor){
		if(isEmpty())
			return false;
		if(this.ele.getValor() == valor){
			return true;
		}
		else{
			if(valor < this.ele.getValor()){
				if(this.esq == null)
					return false;
				else{ return (this.esq.busca(valor));}
			}
			else if(valor > this.ele.getValor()){
				if(this.dir == null)
					return false;
				else{ return (this.dir.busca(valor));}
			}
		}
		return false;
	}
	public bool isEmpty(){
		return (this.ele == null);
	}

	public void inserir(Elemento novo){
		if(isEmpty()){
			this.ele = novo;
		}
		else{
			Arvore novaArvore = new Arvore(novo);
			if(novo.getValor() < this.ele.getValor()){
				if(this.esq == null) {
					this.esq = novaArvore;
					//  Debug.Log("Inseri "+novo.getValor()+" à esquerda de " +this.ele.getValor());
				}
				else{this.esq.inserir(novo);}
			}
			if(novo.getValor() > this.ele.getValor()){
				if(this.dir == null){
					this.dir = novaArvore;
					//   Debug.Log("Inseri "+novo.getValor()+" à direita de " +this.ele.getValor()); 
				}

				else{ this.dir.inserir(novo); }
			}
		}    
	}


	public Arvore getEsquerda() {
		if (esq != null)
			return esq;
		else
			return null;
	}

	public Arvore getDireita() {
		return dir;
	}

	public Elemento getElemento() {
		Elemento novo = new Elemento(-666, -666, -666);
		if (ele != null) 
			return ele;
		else 
			return novo;
	}

	public void setEsquerda(Arvore esq) {
		this.esq = esq;
	}

	public void setDireita(Arvore dir) {
		this.dir = dir;
	}

	public void setElemento(Elemento ele) {
		this.ele = ele;
	}








	}
