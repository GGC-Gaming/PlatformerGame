using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myBod;
    GroundCheck myGC;
    Animator myAnim;

    public float speed;
    public float jump;

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
}
