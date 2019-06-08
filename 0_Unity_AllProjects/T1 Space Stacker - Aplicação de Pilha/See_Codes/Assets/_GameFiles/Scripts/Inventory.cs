using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour {
    public const int numItemSlots = 3;
    public Image[] itemImages = new Image[numItemSlots];
    public Item[] itens = new Item[numItemSlots];



    public void AddItem(Item itemToAdd)
    {
        for (int i = 0; i < itens.Length; i++)
        {    if(itens[i] == null)
            {
                itens[i] = itemToAdd;
                itemImages[i].sprite = itemToAdd.sprite;
                itemImages[i].enabled = true;
                return;
            }

        }



    }

    public void RemoveItem(Item itemToRemove)
    {
        for (int i = 0; i < itens.Length; i++)
        {
            if (itens[i] == itemToRemove)
            {
                itens[i] = null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                return;
            }

        }



    }

}
