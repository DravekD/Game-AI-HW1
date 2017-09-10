using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float speed = 2f;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-speed, 0);
            rb2d.MoveRotation(180);
        }
        else if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(speed, 0);
            rb2d.MoveRotation(0);
        }
        else if (Input.GetKey("s"))
        {
            rb2d.velocity = new Vector2(0, -speed);
            rb2d.MoveRotation(90);
        }
        else if (Input.GetKey("w"))
        {
            rb2d.velocity = new Vector2(0, speed);
            rb2d.MoveRotation(270);
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        //rb2d.AddForce(movement * speed);
    }
}
