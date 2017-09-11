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

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-speed, 0);
            this.transform.rotation = Quaternion.AngleAxis(180f, Vector3.forward);
            //transform.SetPositionAndRotation(transform.position, new Quaternion(0f, 0f, 180f, 0f));
        }
        else if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(speed, 0);
            this.transform.rotation = Quaternion.AngleAxis(0f, Vector3.forward);
            //transform.SetPositionAndRotation(transform.position, new Quaternion(0f, 0f, 0f, 0f));
        }
        else if (Input.GetKey("s"))
        {
            rb2d.velocity = new Vector2(0, -speed);
            this.transform.rotation = Quaternion.AngleAxis(270f, Vector3.forward);
            //transform.SetPositionAndRotation(transform.position, new Quaternion(0f, 0f, 90f, 0f));
        }
        else if (Input.GetKey("w"))
        {
            rb2d.velocity = new Vector2(0, speed);
            this.transform.rotation = Quaternion.AngleAxis(90f, Vector3.forward);
            //transform.SetPositionAndRotation(transform.position, new Quaternion(0f, 0f, 270f, 0f));
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
