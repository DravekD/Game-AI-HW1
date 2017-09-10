using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletTrigger : MonoBehaviour {

    public Globals global_reference;
    private Transform transform;

	void OnTriggerEnter2D (Collider2D other)
    {
        //if (other.GetComponent<Rigidbody2D>() != null)
        {
            //Debug.Log("Hi");
            global_reference.addScore();
            transform = GetComponent<Transform>();
            //Destroy(transform.parent.gameObject);
        }
    }
}
