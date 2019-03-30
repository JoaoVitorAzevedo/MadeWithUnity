using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait, startWait, waveWait;

    public Text scoreText, restartText, gameOverText;
    private bool gameOver, restart;
    public int score;

    GameObject whereIsScore;
    // Use this for initialization
    void Start () {

        /*  whereIsScore = GameObject.FindWithTag("scoreTag");
          if (whereIsScore != null) {
              scoreText = whereIsScore.GetComponent<Text>();

          }
          if (scoreText == null)
              Debug.Log("Cannot find scoreTag");
              */
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine (SpawnWaves());
		
	}
	
	// Update is called once per frame
	void Update () {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



            }

        }
		
	}

    public void GameOver() {
        gameOverText.text = "Game Over!";
        gameOver = true;



    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();

    }
    void UpdateScore() {
        
        scoreText.text = "Score:  " + score;


    }
    


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {

            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPos = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                    spawnValues.y, spawnValues.z);
                Quaternion spawnRot = Quaternion.identity;
                Instantiate(hazard, spawnPos, spawnRot);
                yield return new WaitForSeconds(spawnWait);

            }
            yield return new WaitForSeconds(waveWait);
            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }
}
