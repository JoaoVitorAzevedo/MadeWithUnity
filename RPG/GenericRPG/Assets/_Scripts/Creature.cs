using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour {

    public float range;
    public float totalHealth;
    public int damage;
    public float currentHealth;
    public float moveSpeed;
    protected CharacterController controller;
    public Animation anim;

    float elapsedForRegen = 0.0f;
    public float lifeRegenPerSecond;

    public bool  alive;


	// Use this for initialization
	protected void Start () {
        alive = true;
        currentHealth = totalHealth;
        //InvokeRepeating("regenLife", 1, 1);




    }
	
	// Update is called once per frame
public	void Update () {
        //RegenLife(lifeRegenPerSecond);
               		
	}

    public float getMoveSpeed()
    {
        return this.moveSpeed;
    }
    public float getCurrentHealth()
    {
        return this.currentHealth;
    }

    public void getDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
            currentHealth = 0;

    }
    public void RegenLife(float totalCure)
    {
        elapsedForRegen += Time.deltaTime;
        if (elapsedForRegen >= 1.0f)
        {
            elapsedForRegen = 0.0f;
            if (this.currentHealth < this.totalHealth && !isDead())
            {
                currentHealth += totalCure;
            }

            if (currentHealth > totalHealth)
                currentHealth = totalHealth;
        }
    }
    protected bool isDead()
    {

        if (currentHealth <= 0)
        {
            alive = false;
            return true;
        }
        else
        {
            alive = true;
            return false;
        }
    }

}
