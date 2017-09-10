using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour {

    public Globals global_reference;
    private Text score;

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = global_reference.getScore().ToString().PadLeft(5, '0');
        //score.text = (global_reference.score).ToString("00000");
	}
}
