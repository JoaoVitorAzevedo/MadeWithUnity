using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour {

    public int[] values;
    public int topo; public int qtdElementos;

    public Stack()
    {
        values = new int[2];
        topo = -1; qtdElementos  = 0;
    }

    public void Empilha(Stack p, int value, bool ok)
    {
        if(Cheia(p) == false)
        {
            topo++;
            p.values[topo] = value;
            qtdElementos++;

        }
        
    }

    public int Desempilha(Stack p, int x, bool ok)
    {
        if(Vazia(p) == false)
        {
            x = p.values[topo]; //p.values[topo] = null;
            topo--; qtdElementos--;
            return x;
        }
        else { Debug.Log("Fiz nada"); return 0;  }
    }
   public  bool Cheia(Stack p)
    {
        if(qtdElementos == p.values.Length)
        {
            return true;
        }
        else { return false; }
    }

    public bool Vazia(Stack p)
    {
        return (qtdElementos == -1);
    }
    
}
