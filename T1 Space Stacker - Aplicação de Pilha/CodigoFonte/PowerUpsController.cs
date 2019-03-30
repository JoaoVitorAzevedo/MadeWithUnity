using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpsController : MonoBehaviour {

    public Image[] imShield; public Image[] imRate;
    public Stack pilha; int x; bool ok;
    private void Start()
    {
       // pilha = new Stack();
    }
    private void Update()
    {

        DesignPill();
        
    }
    public void DesignPill()
    {
        Stack pillCopy = new Stack();
        
        for (int i = 0; i < pilha.values.Length; i++)
        {
            pilha.Desempilha(pilha, x, ok); 
            if (x == 1)
            {
                imShield[i].enabled = true;
                imRate[i].enabled = false;
            }

        }
        for (int i = 0; i < pilha.values.Length; i++)
        {
            pillCopy.Empilha(pillCopy, x, ok);
        }





    }
}
