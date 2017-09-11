using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Globals : MonoBehaviour {

    private int score = 0;
    private int high_score;

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
}
