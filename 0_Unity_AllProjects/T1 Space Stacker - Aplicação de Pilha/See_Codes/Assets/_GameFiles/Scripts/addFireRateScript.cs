using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class addFireRateScript : MonoBehaviour
{
    
    public float duration;
    public GameObject vary;
    Stack pilha;
    bool ok;

    public GameObject pickupEffect;
    // Use this for initialization
    void Start()
    {
        
        vary = GameObject.FindGameObjectWithTag("GameController");


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator PickUp(Collider player)
    {// spawn effect
        // apply to player
        // remove object pickable from the scene
        playerController pl = player.GetComponent<playerController>();
        Debug.Log("pickup powerupp");
        Instantiate(pickupEffect, pl.transform.position, pl.transform.rotation);

         pilha = vary.GetComponent<Stack>();
        pilha.Empilha(pilha, 0, ok); 
        
        
        pl.fireRate = 0.1f;
        MeshRenderer[] gv; BoxCollider[] bc;
        //GetComponent<MeshRenderer>().enabled = false;
        //gv = GetComponent<BoxCollider>();

        gv = GetComponentsInChildren<MeshRenderer>();
        bc = GetComponentsInChildren<BoxCollider>();
        foreach (var MeshRenderer in gv)
        {
            MeshRenderer.enabled = false;

        }
        foreach (var BoxCollider in bc)
        {
            BoxCollider.enabled = false;

        }


        // wait and reverse


        yield return new WaitForSeconds(duration);
        pl.fireRate = 0.25f;
        Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(PickUp(other));
        }
    }


}
