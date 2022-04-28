using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myBod;
    GroundCheck myGC;
    Animator myAnim;

    public float speed;
    public float jump;
    public static int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        myBod = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        myGC = GetComponentInChildren<GroundCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float vx = speed * h;
        float vy = myBod.velocity.y;

        if (Mathf.Abs(h) > 0.1)
        {
            myAnim.SetBool("RUN", true);
        }
        else
        {
            myAnim.SetBool("RUN", false);
        }

        if (Input.GetButtonDown("Jump") && myGC.isGrounded)
        {
            vy = jump;
        }
        myBod.velocity = new Vector2(vx, vy);
    }

void takeDamage()
    {
        if (lives > 0)
        {
            // Resets the current scene to the beginning 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            lives--;
            Debug.Log(lives);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.tag == "DangerousObject")
        {

            takeDamage();
        }
    }
}
