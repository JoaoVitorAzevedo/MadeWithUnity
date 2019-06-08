using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour {

    public GameObject player;
    public Texture2D frame;
    public Rect framePosition;

    public Texture2D healthBar;
    public Texture2D healthLost;
    public Rect healthBarPos;

    public GameObject target;
    public float healthPercentage;
    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        
        
		
	}
	
	// Update is called once per frame
	void Update () {

        
        target = player.GetComponent<Player>().opponent;

        if (player.GetComponent<Player>().opponent != null)
        {
            healthPercentage = (float) target.GetComponent<Enemy>().currentHealth / (float) target.GetComponent<Enemy>().totalHealth;
        }
        else
        {
            target = null;
            healthPercentage = 0;
        }
		
	}

    private void OnGUI()
    {
         framePosition.x = (Screen.width - framePosition.width) / 2;

        healthBarPos.x = (Screen.width - healthBarPos.width) / 2;
         
        framePosition.width = Screen.width * 0.46f;
        framePosition.height = Screen.height * 0.097f;
        healthBarPos.width = Screen.width * 0.46f * healthPercentage;
        healthBarPos.height = Screen.height * 0.097f;

        // framePosition.y = 200;
        if (target != null)
        {
            GUI.DrawTexture(framePosition, frame);
            GUI.DrawTexture(healthBarPos, healthLost);
            GUI.DrawTexture(healthBarPos, healthBar);
        }

        


    }
}
