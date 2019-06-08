using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Buttoncode : MonoBehaviour {



	UnityEvent m_Event = new UnityEvent ();
	Button me;
	public int x; // 0 para esquerda, 1 para direita 
	public GameControl gma;
	public Arvore auxdoAux; 
	void Start () {
		// raiz era 1, aux era 3

		auxdoAux = null;
		auxdoAux = new Arvore ();



		
		 me = this.GetComponent<Button> ();
		 gma = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameControl> ();

		if(SceneManager.GetActiveScene().name != "templateScene"){
			gma.raiz = null;
			gma.raiz = new Arvore ();		//transformei raiz em aux ( subArvore dir-esq) 
		gma.raiz.addAsCria (gma.aux);


		}


		auxdoAux.addAsCria (gma.raiz);  // aux do aux = raiz ( que é a aux? ue )

		//gma.aux = new Arvore ();



		 //	gma = GameObject.FindWithTag ("GameController").GetComponent<GameControl> ();

		//Debug.Log ("atribui gma");
		//me.onClick.AddListener (gma.gm.VapraEsq());
		//me.onClick.AddListener ();
			//m_Event.AddListener(myAction);
		if (x == 0) {
			me.onClick.AddListener (myAction); // call esquerda
		}
		if (x == 1) {
			me.onClick.AddListener (myAction2); // call direita
		}

		Debug.Log("Agora no fim do start, a raiz foi pra "+ gma.raiz.getElemento().getGuideNode() +" E aux foi pra"+ gma.aux.getElemento().getGuideNode()); 

	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void myAction(){
		
		Debug.Log("Quando cliquei no myAction, a raiz foi pra "+ gma.raiz.getElemento().getGuideNode() +" E aux foi pra"+ gma.aux.getElemento().getGuideNode()); 
		// gma.aux = new Arvore();
		//gma.raiz = gma.TreeFases.getEsquerda ();
		//gma.raiz = new Arvore();
		//gma.aux.free(gma.aux);
		auxdoAux.addAsCria(gma.aux);
		gma.aux = null;
		gma.aux = new Arvore();
		gma.aux.addAsCria(auxdoAux.getEsquerda());
		Debug.Log ("Indo pro node codigo " + gma.aux.getElemento().getmyId());
		Debug.Log ("chamei esq");

		Debug.Log("printando logo antes de chamar a next Scene, dentro do myact a raiz foi pra "+ gma.raiz.getElemento().getGuideNode() +" E aux foi pra "+ gma.aux.getElemento().getGuideNode()); 



		SceneManager.LoadScene (gma.aux.getElemento ().getmyId ());
	
	}


	void myAction2(){
		Debug.Log("Quando cliquei no myAction2, a raiz foi pra "+ gma.raiz.getElemento().getGuideNode() +" E aux foi pra "+ gma.aux.getElemento().getGuideNode()); 

		//gma.raiz = new Arvore();
		//gma.raiz = gma.TreeFases.getDireita ();
		 //gma.aux = new Arvore();
	//	gma.raiz.addAsCria(gma.raiz.getDireita());
		//gma.aux.free(gma.aux);
		//gma.aux.free(gma.aux);	

		//auxdoAux.addAsCria (gma.aux);
		auxdoAux.addAsCria(gma.aux);

		gma.aux = null;
		gma.aux = new Arvore();
		gma.aux.addAsCria (auxdoAux.getDireita ());
		//gma.aux = null;
		//gma.aux = new Arvore();
		//gma.aux.addAsCria(gma.raiz.getDireita());
		Debug.Log ("Indo pro node codigo " + gma.aux.getElemento().getmyId());
		Debug.Log ("chamei dir");
		Debug.Log("printando logo antes de chamar a next Scene, dentro do myact2 a raiz foi pra "+ gma.raiz.getElemento().getGuideNode() +" E aux foi pra "+ gma.aux.getElemento().getGuideNode()); 

		//gma.raiz = new Arvore ();

		SceneManager.LoadScene (gma.aux.getElemento ().getmyId ());

	}
}
