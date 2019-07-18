    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour {

    //we need a formula to calculate exp needed

    public int level;
    public int exp;
    public Player me;

	// Use this for initialization
	void Start () {
        level = 1;
        exp = 0;
        me = this.GetComponent<Player>();

		
	}
	
	// Update is called once per frame
	void Update () {
        LevelUp();
		
	}

     

    void LevelUp()
    {
        if(exp >= Mathf.Pow(level, 2) + 100)
        {

            int v = (int) Mathf.Pow(level, 2) + 100;
            exp = exp - v;
            level += 1;
            LevelEffect();

        }
    }

    void LevelEffect()
    {
        me.totalHealth += Mathf.Pow(level, 2) + 100;
        me.currentHealth = me.totalHealth;
        me.damage += (int)Mathf.Pow(level, 2);




    }
}
