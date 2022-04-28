using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rigidB;

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
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
