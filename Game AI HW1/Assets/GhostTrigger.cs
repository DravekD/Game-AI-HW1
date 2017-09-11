using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTrigger : MonoBehaviour {

    private int direction;
    private float speed = 1f;
    private Rigidbody2D rb2d;
    private int time = 0;
    public Globals global_reference;

    void Start()
    {
        direction = Random.Range(0,3);
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.freezeRotation = true;
    }

    void FixedUpdate()
    {
        time++;
        if (time == 120)
        {
            time = 0;
            direction = Random.Range(0,3);
        }
        if (direction == 0)
        {
            rb2d.velocity = new Vector2(-speed, 0);
            this.transform.rotation = Quaternion.AngleAxis(90f, Vector3.forward);
        }
        else if (direction == 1)
        {
            rb2d.velocity = new Vector2(speed, 0);
            this.transform.rotation = Quaternion.AngleAxis(270f, Vector3.forward);
        }
        else if (direction == 2)
        {
            rb2d.velocity = new Vector2(0, speed);
            this.transform.rotation = Quaternion.AngleAxis(0f, Vector3.forward);
        }
        else if (direction == 3)
        {
            rb2d.velocity = new Vector2(0, -speed);
            this.transform.rotation = Quaternion.AngleAxis(180f, Vector3.forward);
        }
        else
        {
            Debug.Log("Invalid ghost direction value");
        }
        
    }


    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.name == "Player(Clone)")
        {
            Destroy(other.gameObject);
            global_reference.gameOver();
        }
        else if (other.gameObject.name != "Pellet(Clone)")
        {
            direction = Random.Range(0,3);
        }
    }
}
