using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Globals : MonoBehaviour {

    private int score;
    private int lives;

    void Start()
    {
        score = 0;
        lives = 3;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public int getScore()
    {
        return score;
    }

    public void addScore()
    {
        score += 1;
    }

    public int getLives()
    {
        return lives;
    }

    void Update()
    {
        score = score;
    }
}
