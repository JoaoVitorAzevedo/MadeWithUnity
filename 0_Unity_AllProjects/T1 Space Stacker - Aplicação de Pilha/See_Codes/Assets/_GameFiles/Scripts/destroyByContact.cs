using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByContact : MonoBehaviour {


    public GameObject explosion;
    public GameObject playerExplosion;
    private gameController gameController;
    public int scoreValue;

	// Use this for initialization
	void Start () {

        GameObject gameControllerObj;
        
        gameControllerObj = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObj != null)
            gameController = gameControllerObj.GetComponent<gameController>();

        if (gameController == null)
        {
            Debug.Log("gameController NULL");


        }

    }
    
	
	// Update is called once per frame
	void Update () {
		
	}

    

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }

        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
