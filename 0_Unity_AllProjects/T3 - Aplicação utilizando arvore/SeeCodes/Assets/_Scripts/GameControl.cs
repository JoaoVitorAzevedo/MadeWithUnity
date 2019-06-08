using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour	{


	// 	public Arvore treeFases = new Arvore(); desisti de usar a arvore para um super controle das cenas, pois os atributos dos botoes precisariam mudar muitas vezes
	// public Elemento inicial = new Elemento(21,); o que afeta muito a performance.


	// usei a arvore apenas para os SceneManager.LoadScene mesmo. A Arvore apenas mantém algumas informações sobre a cena atual, mas foram sim necessárias criar várias cenas.
	// Use this for initialization

	public Arvore TreeFases; 
	public Arvore raiz;
	public Elemento novo;
	public GameControl gm;
	public Arvore aux;





	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameControl>(); //this.gameObject.GetComponent<GameControl> ();
		//raiz = TreeFases;

	//	DontDestroyOnLoad (this.gameObject);
		novo = new Elemento (50,0,1);
		TreeFases = new Arvore(novo);	//																				20





		raiz = new Arvore ();			//																			10		30
										//																		5				35			
	//	TreeFases.inserir (novo);																			2	   7		  32   38



	
		modularizaInsercao (TreeFases,25,1,2);
		modularizaInsercao (TreeFases,75,1,3);
		modularizaInsercao (TreeFases,12,20,4);
		modularizaInsercao (TreeFases,62,20,6);
	//modularizaInsercao (TreeFases,62,20,8);
		//modularizaInsercao (TreeFases,88,20,7);
		modularizaInsercao (TreeFases,18,30,9);


		modularizaInsercao (TreeFases,56,10,12);
		modularizaInsercao (TreeFases,68,30,13);
		modularizaInsercao (TreeFases,6,10,8);

	








		novo = new Elemento (3,35,16);
		TreeFases.inserir (novo);


		//novo = new Elemento (0, "Vá para 1", "Vá para 1");
		//	TreeFases.inserir (novo);
		//	novo = new Elemento (0, "Vá para 1", "Vá para 1");
		//	TreeFases.inserir (novo);
		//	novo = new Elemento (0, "Vá para 1", "Vá para 1");
		//TreeFases.inserir (novo);

		//TreeFases.inOrdem ();

		//TreeFases.inOrdem ();

		//Debug.Log (TreeFases.getElemento ().getValor ());

		raiz.addAsCria (TreeFases);	
		aux = new Arvore ();
		aux.addAsCria (raiz);
		
	}

	void modularizaInsercao(Arvore TreeFases, int valor, int faseQueChama, int id){
		Elemento el = new Elemento (valor, faseQueChama, id);
		TreeFases.inserir (el);
	}
	
	// Update is called once per frame
	void Update () {
		//Start ();


	}

	public void iniciaJogo(){
		SceneManager.LoadScene ("templateScene");
	}


	public void VapraEsq(){
		//raiz = TreeFases.getEsquerda ();
   //SceneManager.LoadScene(raiz.getElemento().getValor());
		//Debug.Log("Tentei chamar a ceninha da esquerda, que é a nro:" + raiz.getElemento().sceneId);
		//Debug.Log("Tentei chamar a ceninha da esquerda, que é a nro:" + TreeFases.getEsquerda().getElemento().sceneId);
	//	TreeFases.inOrdem ();
		//SceneManager.LoadScene(0);
		//SceneManager.LoadScene(this.TreeFases.getElemento().sceneId);
		//raiz.inOrdem();
		//raiz.inOrdem ();
	//	Debug.Log(gm.TreeFases.getElemento());
		Debug.Log("Fui pra Esc");
		SceneManager.LoadScene(gm.TreeFases.getEsquerda().getElemento().getmyId());

	}


	public void VapraDir(){	
		
		//raiz = this.TreeFases.getDireita();
		// SceneManager.LoadScene(raiz.getElemento().getValor());

		////Debug.Log("Tentei chamar a ceninha da direita, que é a nro:" + raiz.getElemento().sceneId);
		//TreeFases.inOrdem ();
	//	Debug.Log("Tentei chamar a ceninha da direita, que é a nro:" + TreeFases.getDireita().getElemento().sceneId);
		//SceneManager.LoadScene(this.TreeFases.getElemento().sceneId);

	//	raiz.inOrdem();
		//raiz.inOrdem ();
	//	gm.raiz.inOrdem ();
		Debug.Log("Fui pra dir");
				SceneManager.LoadScene(gm.TreeFases.getDireita ().getElemento().getmyId());
	}

	public void vaPra(int codeScene){
		if (codeScene == 0)
			destroyMe ();


		SceneManager.LoadScene (codeScene);
	}


	public void destroyMe(){
		Destroy (this.gameObject);
	}
}
