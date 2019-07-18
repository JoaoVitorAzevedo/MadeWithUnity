using UnityEngine;

public class Player : Creature
{

    public AnimationClip attackAnim;
    public AnimationClip dieAnim;
    bool startedDieAnim;
    bool endedDieAnim;

    public double impactTime;

    public float combatEscapeTime;
    public float countDown;



    // Use this for initialization
    void Start()
    {
        anim = this.GetComponent<Animation>();
        base.Start();
        

    }



    // Update is called once per frame
    void Update()
    {
        RegenLife(lifeRegenPerSecond);
        if(!isDead())
            attack();

    }
    void impact()
    {
        if (opponent != null && this.GetComponent<Animation>().IsPlaying(attackAnim.name) && !impacted)
        {
            if ((anim[attackAnim.name].time > anim[attackAnim.name].length * impactTime && anim[attackAnim.name].time < 0.9 * anim[attackAnim.name].length))
            {
                countDown = combatEscapeTime;
                CancelInvoke("combatEscapeCountDown");
                InvokeRepeating("combatEscapeCountDown", 0, 1);
                opponent.GetComponent<Enemy>().getDamage(this.damage);
                impacted = true;
            }

        }


    }
    bool inRange()
    {
        return (Vector3.Distance(opponent.transform.position, this.transform.position) < range);

    }

    bool isDead()
    {



        return base.isDead();


    }
    void combatEscapeCountDown()
    {
        countDown -= 1;
        if(countDown == 0)
        {
            CancelInvoke("combatEscapeCountDown");
        }

    }

    void attack()
    {
        if (Input.GetKey(KeyCode.Space) && inRange())
        {

            this.GetComponent<Animation>().Play(attackAnim.name);
            ClickToMove.isAttacking = true;
            if (opponent != null)
            {
                transform.LookAt(opponent.transform.position);
            }



        }

        if (anim[attackAnim.name].time > 0.9 * anim[attackAnim.name].length)

        //if (!anim.IsPlaying(attack.name))
        {
            ClickToMove.isAttacking = false;
            impacted = false;

        }
        impact();






    }

    void dieMethod()
    {

        if (isDead())
        {
            if (!startedDieAnim)
            {
                anim.Play(dieAnim.name);
                startedDieAnim = true;
                this.GetComponent<ClickToMove>().enabled = false;

            }

            if (startedDieAnim && !anim.IsPlaying(dieAnim.name))
            {
                //endedDieAnim = true; 

                endedDieAnim = true;
                this.GetComponent<ClickToMove>().enabled = false; // gambiarra aqui e acima, pra economizar update
                //deu certo po rs

            }

            if (isDead() && !endedDieAnim)
            {
                anim.Play(dieAnim.name);


            }
        }
    }

    public void getDamage(float damage)
    {
        base.getDamage(damage);
        this.dieMethod();
    }
    public void RegenLife(float totalCure)
    {
        totalCure += (0.02f * totalHealth);
        base.RegenLife(totalCure);

    }

}
