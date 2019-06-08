using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buffsSpawn : MonoBehaviour
{

    public GameObject[] buffs;
    public Vector3 spawnValues;
    public int buffCount;
    public float spawnWait, startWait, waveWait;

    

    GameObject whereIsScore;
    // Use this for initialization
    void Start()
    {

        /*  whereIsScore = GameObject.FindWithTag("scoreTag");
          if (whereIsScore != null) {
              scoreText = whereIsScore.GetComponent<Text>();

          }
          if (scoreText == null)
              Debug.Log("Cannot find scoreTag");
              */
        
        StartCoroutine(SpawnWaves());

    }

    // Update is called once per frame
    

   
    



    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {

            for (int i = 0; i < buffCount; i++)
            {
                GameObject hazard = buffs[Random.Range(0, buffs.Length)];
                Vector3 spawnPos = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                    spawnValues.y, spawnValues.z);
                Quaternion spawnRot = Quaternion.identity;
                spawnRot.x = 0; spawnRot.y = 0;
                Instantiate(hazard, spawnPos, spawnRot);
                yield return new WaitForSeconds(spawnWait);

            }
            yield return new WaitForSeconds(waveWait);
            
        }
    }
}
