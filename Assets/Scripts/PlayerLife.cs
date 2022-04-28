using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rigidB;
    [SerializeField] public int maxPlayerLives = 3;
    public static int currentPlayerLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        rigidB = GameObject.Find("Player").GetComponent<Rigidbody2D>();

    }


    void OnTriggerEnter2D(Collider2D otherObject)
    {

        //When something enters this object's trigger collider, check if it is the player.
        if (otherObject.name == "Player")
        {

            // Resets the current scene to the beginning 
            if (currentPlayerLives == 0)
            {
                SceneManager.LoadScene("JustinTestScene");
                currentPlayerLives = maxPlayerLives;
            }
            else
            {
                RestartLevel();
            }
            Debug.Log(currentPlayerLives);
        }
    }

    private void RestartLevel()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            currentPlayerLives--;
    }
}
