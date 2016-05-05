using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    private GameController gameController;
    public int scoreValue; // used so in the unity editor we can set the value a destroyed object will have
    public GameObject explosion;
    public GameObject playerExplosion;

    void Start()
    {
        // the tag will look for the object that has that tag
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        // Just in case we can find it. It will help to find the error
        if (gameControllerObject == null)
        {
            Debug.Log("Can't find 'GameController' script");
        }
        else
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
        {
            return;
        }

        else if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.whenGameOver();
        }

        // there is an explosion
        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        // Calls the gameController addScore and update it with the scoreValue
        gameController.addScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
