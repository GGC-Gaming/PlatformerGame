using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagGoal : MonoBehaviour
{

    //Function is called when something enters this object's trigger collider.
    void OnTriggerEnter2D(Collider2D otherObject)
    {

        //When something enters this object's trigger collider, check if it is the player.
        if (otherObject.name == "Player")
        {

            //This will send the player to the next level, according to the build settings.
            //If there is not a next level, end the game.
            Debug.Log("Player has reached an exit!");

            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            if (SceneManager.sceneCount > currentSceneIndex)
            {
                SceneManager.LoadScene(currentSceneIndex + 1);
            } else
            {
                Debug.Log("The game should have closed.");
                Application.Quit();
            }

        }
    }

}
