using UnityEngine;

public class Enemy : Creature
{



    private GameObject player;


    //private Animation anim;
    public AnimationClip attackAnim;
    public AnimationClip run;
    public AnimationClip idle;
    public AnimationClip die;

    public double impactTime;
    public bool impacted;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        controller = this.GetComponent<CharacterController>();
        anim = this.GetComponent<Animation>();
        base.Start();
        this.opponent = GameObject.FindGameObjectWithTag("Player");

    }


    // Update is called once per frame
    void Update()
    {
        RegenLife(lifeRegenPerSecond);

        if (!isDead())
        {
            if (!inRange())
            {
                chase();

            }
            else
            {
                //anim.CrossFade(idle.name);
                attack();
                if(anim[attackAnim.name].time > 0.9 * anim[attackAnim.name].length)
                {
                    impacted = false;
                }
            }
        }

        else
        {
            dieMethod();
        }
    }

    void attack()
    {
        if (opponent.GetComponent<Player>().currentHealth > 0)
        {
            anim.Play(attackAnim.name);

            if (anim[attackAnim.name].time > anim[attackAnim.name].length * impactTime && !impacted
                && anim[attackAnim.name].time < 0.9 * anim[attackAnim.name].length)
            {
                impacted = true;
                opponent.GetComponent<Player>().getDamage(this.damage);



            }


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

    void chase()
    {
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

    
    void dropLoot()
    {
        //instantiate the loot in the area near the mob
    }
    private void OnMouseOver()
    {
        player.GetComponent<Player>().opponent = gameObject;
    }

    public void RegenLife(float totalCure)
    {
        totalCure += (0.01f * totalHealth);
        base.RegenLife(totalCure);

    }

}
