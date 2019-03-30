using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



	public class aplicacaoQueUsaArvore
	{
		public aplicacaoQueUsaArvore ()
		{
		}



		static void Main(){
		System.Console.WriteLine ("Fodasi");
			Arvore arvore = new Arvore(new Elemento(20));

			Elemento elemi = new Elemento(0);


			arvore.inserir(new Elemento(10));
			arvore.inserir(new Elemento(5));
			arvore.inserir(new Elemento(2));
			arvore.inserir(new Elemento(8));
			arvore.inserir(new Elemento(15));
			arvore.inserir(new Elemento(12));
			arvore.inserir(new Elemento(18));
			arvore.inserir(new Elemento(30));
			arvore.inserir(new Elemento(25));
			arvore.inserir(new Elemento(22));
			arvore.inserir(new Elemento(28));
			arvore.inserir(new Elemento(35));
			arvore.inserir(new Elemento(32));
			arvore.inserir(new Elemento(38));

			//  System.out.println("O Elemento 5 " + (arvore.busca(5) ? " existe": "nao existe"));
			//  System.out.println("O Elemento 12 " + (arvore.busca(12) ? " existe": "nao existe"));
			//   System.out.println("O Elemento 8 " + (arvore.busca(8) ? " existe": "nao existe"));
			//    System.out.println("O Elemento 34 " + (arvore.busca(34) ? " existe": "nao existe"));


			//   arvore.preOrdem();
			//    System.out.println("");
			arvore.inOrdem(); 
			Debug.Log("");
			//   arvore.posOrdem(); System.out.println("");
			elemi.setValor(38);

			arvore = arvore.remover(elemi);
			Debug.Log("nova arbore");
			arvore.inOrdem();     
			Debug.Log("");

			elemi.setValor(35);
			arvore = arvore.remover(elemi);
			Debug.Log("nova arbore");
			arvore.inOrdem();     
			Debug.Log("");

			elemi.setValor(20);
			arvore = arvore.remover(elemi);
			Debug.Log("nova arbore");
			arvore.inOrdem();     
			Debug.Log("");


		}

	}




