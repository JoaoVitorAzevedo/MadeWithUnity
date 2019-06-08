using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Creature {

    public GameObject opponent;
    public AnimationClip attack;

    public double impactTime;  
    public bool impacted = false;


 
	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animation>();
        base.Start();
		
	}
	
	// Update is called once per frame
	void Update () {
        RegenLife(lifeRegenPerSecond);

        if (Input.GetKey(KeyCode.Space) && inRange())
        {
            this.GetComponent<Animation>().Play(attack.name);
            ClickToMove.isAttacking = true;
            if (opponent != null)
            {
                transform.LookAt(opponent.transform.position);
            }
            


        }

        if (anim[attack.name].time > 0.9 * anim[attack.name].length)
        
            //if (!anim.IsPlaying(attack.name))
            {
                ClickToMove.isAttacking = false;
                impacted = false;

            }
            impact();

        
		
	}
    void impact() {
        if(opponent != null && this.GetComponent<Animation>().IsPlaying(attack.name) && !impacted)
        {
            if((anim[attack.name].time > anim[attack.name].length * impactTime && anim[attack.name].time < 0.9 * anim[attack.name].length))
            {
                opponent.GetComponent<Mob>().getDamage(this.damage);
                impacted = true;
            }

        }


    }
    bool inRange()
    {
        return (Vector3.Distance(opponent.transform.position, this.transform.position) < range);
          
    }

    public void RegenLife(float totalCure)
    {
        totalCure += (0.02f * totalHealth);
        base.RegenLife(totalCure);

    }

}
