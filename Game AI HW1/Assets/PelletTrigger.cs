using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletTrigger : MonoBehaviour {

    public Globals global_reference;

	void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Player(Clone)")
        {
            global_reference.addScore();
            Destroy(this.gameObject);
        }
    }
}
