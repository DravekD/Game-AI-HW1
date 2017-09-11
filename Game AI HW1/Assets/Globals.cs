using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class Globals : MonoBehaviour {

    private int score = 0;
    private int high_score;
    private string path = "Assets/HighScore.txt";

    void Start()
    {
        score = 0;
    }

    public void setHighScore(int x)
    {
        high_score = x;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void resetScore()
    {
        score = 0;
    }

    public int getScore()
    {
        return score;
    }

    public void addScore()
    {
        score += 1;
    }

    public void gameOver()
    {
        if (score > high_score)
        {
            File.WriteAllText(path, string.Empty);
            //StreamWriter writer = new StreamWriter(path);
            //writer.Write(high_score);
        }
    }
}
