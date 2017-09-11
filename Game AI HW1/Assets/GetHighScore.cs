using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class GetHighScore : MonoBehaviour {

    private string path = "Assets/HighScore.txt";

	// Use this for initialization
	void Start () {

        if (!(File.Exists(path)))
        {
            Debug.LogError("Invalid Path");
        }
        else
        {
            StreamReader reader = new StreamReader(path);
            Text score = GetComponent<Text>();
            score.text = reader.ReadLine();
        }
    }
}
