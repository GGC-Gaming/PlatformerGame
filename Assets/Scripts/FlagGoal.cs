using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagGoal : MonoBehaviour
{

    //Function is called when something enters this object's trigger collider.
    void OnTriggerEnter2D(Collider2D otherObject)
    {

        //When something enters this object's trigger collider, check if it is the player.
        if (otherObject.name == "Player")
        {

            //If the player entered this object's trigger collider, close the application.
            //This will need to be changed to go to next level, but close application on no next level.
            Debug.Log("Player has reached an exit!");
            Application.Quit();
        }
    }

}
