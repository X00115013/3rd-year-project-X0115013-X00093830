using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {
    private int score; //used to store score.
    private bool gameOver, restart;

    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount; // Number of times we cycle through the loop
    // spawnWait will hold our wait time,
    public float spawnWait, startWait, waveWait;

    public GUIText scoreText; // Ref to GUI Text component
    public GUIText restartText;
    public GUIText gameOverText;

    // Use this for initialization
    // Will call on the method spawnWaves as soon as the game starts
    void Start ()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        updateScore();
        // wait without pausing the game
        StartCoroutine(spawnWaves());
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            // Load the level based on index if blank reloads level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    /* This will create the hazards
        Rotates the hazards, spawn their start position.
        IEnumerator allow the function to be used in Coroutine
    */
    IEnumerator spawnWaves()
    {
        // short pause to allow player to get ready
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                // Array set to be random to randomise different hazards.
                // 0 is the start index of the hazards lit to the lenght of the hazard array.
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                // Random.Range will give a random value between a min & max point on our x-axis
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                // Quaternion.identity has no rotation of Quaternion.
                Quaternion spawnRotation = Quaternion.identity;

                /*
                    hazard is the object
                    spawnPosition is vector3  
                */
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(startWait);
            }
            yield return new WaitForSeconds(waveWait);

            if(gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break; // used to stop if true
            }
        }
    }
    
    // Other classes can access this to update score when hazard is destroyed
    public void addScore(int newScore)
    {
        score += newScore;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "Score: " + score;
    }
    
    public void whenGameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }  
}
