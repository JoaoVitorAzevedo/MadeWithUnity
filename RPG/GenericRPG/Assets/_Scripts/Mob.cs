using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : Creature {

    
    
    private GameObject player;
    

    //private Animation anim;
    public AnimationClip run;
    public AnimationClip idle;
    public AnimationClip die;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        controller = this.GetComponent<CharacterController>();
        anim = this.GetComponent<Animation>();
        base.Start(); 

    }

   
    // Update is called once per frame
    void Update () {    
        RegenLife(lifeRegenPerSecond);

        if (!isDead())
        {
            if (!inRange())
            {
                chase();

            }
            else
            {
                anim.CrossFade(idle.name);
            }
        }
        else
        {
            dieMethod();
        }
	}

    bool inRange()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < range)
        {
            return true;
        }
        else return false;


    }

    void chase() {
        transform.LookAt(player.transform);
        controller.SimpleMove(transform.forward * moveSpeed);
        anim.CrossFade(run.name);



    }

    void dieMethod()
    {
        anim.Play(die.name);
        dropLoot();
        if (anim[die.name].time > 0.95 * anim[die.name].length)
        {
            
            Destroy(gameObject);
            
        }

    }
    void dropLoot() {
            //instantiate the loot in the area near the mob
    }
    private void OnMouseOver()
    {
      player.GetComponent<Fighter>().opponent = gameObject;
    }

    public void RegenLife(float totalCure)
    {
        totalCure += (0.01f * totalHealth);
        base.RegenLife(totalCure);

    }

}
