using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	//List<Enemy> lista = new List<Enemy>();
	 
	public int qtdTorus;
	public int qtdGreen;
	public int qtdRed;
	public int qtdLime;
	public int qtdBat;
	public int qtdPhantom;

	public Text[] ui = new Text[6];

	public Image HealthbarLight;

	public Image HealthbarLost;

	public int maxHealth;
	public int currentHealth;

	public Lista listaDoPlayer;


	// Use this for initialization
	void Start () {
		currentHealth = maxHealth; 
		qtdTorus=0;
		qtdGreen=0;
		qtdRed=0;
		qtdLime=0;
		qtdBat =0;
		qtdPhantom=0;
		listaDoPlayer = new Lista();
		//listaDoPlayer.listar ();
		//listaDeEspera();
	}

 void listaDeEspera(){

	//	Lista lista = new Lista();
		//lista.inserir (872);
		//lista.inserir (123);
		//lista.inserir (1597);
		//lista.inserir (2);
		//lista.listar ();

		//while (lista.isEmpty() == false) {
	//		int e = lista.retirar ();
	//		Debug.Log ("Retirei o elemento " + e);
		
		//}

	}


	int i =0;
	// Update is called once per frame
	void Update () {



		HealthbarLight.fillAmount = Mathf.Lerp(HealthbarLight.fillAmount, (float)currentHealth / (float)maxHealth, 0.5f);
		HealthbarLost.fillAmount = Mathf.Lerp(HealthbarLost.fillAmount, (float)currentHealth / (float)maxHealth, 0.01f);
		if (i == 0) {
			listaDoPlayer.listar();
			i = 1;
		}
		updateTextGUI ();
	}

public void getDamage(int dano){
		
		currentHealth = currentHealth - dano;
		if (currentHealth <= 0) {
			Debug.Log ("Morreu"); // gameover = true;
			listaDoPlayer.listar ();
			SceneManager.LoadScene("GameOver");
			//Application.LoadLevel ("GamePlay");
			//sLoadSceneMode
			listaDoPlayer.listar ();


		
		}
			


	}

	public void updateTextGUI(){

		/* Visita e percorre a lista de coisas interagiveis no jogo 
		 * sejam essas inimigos ou coletáveis, e atualiza seus valores atuais na Tela
		 * Usando um vetor de Text's ( objeto padrao da Unity)
		*/
	 		ui [0].text = "Torus: " + listaDoPlayer.contarporCodigo (0) + "x";
			ui [1].text = "CoguGrenn: " + listaDoPlayer.contarporCodigo (1) + "x";
			ui [2].text = "CoguRed: " + listaDoPlayer.contarporCodigo (2) + "x";
			ui [3].text = "Lime: " + listaDoPlayer.contarporCodigo (3) + "x";
			ui [4].text = "Bat: " + listaDoPlayer.contarporCodigo (4) + "x";
			ui [5].text = "Phantom: " + listaDoPlayer.contarporCodigo (5) + "x"; 

		if (listaDoPlayer.contarporCodigo (1) == 0 && listaDoPlayer.contarporCodigo (0) == 0) {
			// o jogador coletou todos os torus e coguGreens, comecar a cena de novo.( provisorio) 
			SceneManager.LoadScene("vcefoda");
		}

	/*	ui[0].text = "Torus: "+qtdTorus+"x";
		ui[1].text = "CoguGreen: "+qtdGreen+"x";
		ui[2].text = "CoguRed: "+qtdRed+"x";		// ignorar este bloco
		ui[3].text = "Lime: "+qtdLime+"x";
		ui[4].text = "Bat: "+qtdBat+"x";
		ui[5].text = "Phantom: "+qtdPhantom+"x"; */
	}


}


