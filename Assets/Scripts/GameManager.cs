using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*
    private int leftPlayerLives = 5;
    private int rightPlayerLives = 5;
    private int leftPlayerScore = 0;
    private int rightPlayerScore = 0;
    */

    private int lives = 5;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Only One
    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
    
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }

    /*
    // Left Player 
    public void LeftPlayerAddLives(int value)
    {
        leftPlayerLives += value;
        if (leftPlayerLives <= 0)
        {
            Debug.Log("Game Over");
            leftPlayerLives = 0;
        }
        Debug.Log("Lives = " + leftPlayerLives);
    }
    
    public void LeftPlayerAddScore(int value)
    {
        leftPlayerScore += value;
        Debug.Log("Score = " + leftPlayerScore);
    }

    // Right Player
    public void RightPlayerAddLives(int value)
    {
        rightPlayerLives += value;
        if (rightPlayerLives <= 0)
        {
            Debug.Log("Game Over");
            rightPlayerLives = 0;
        }
        Debug.Log("Lives = " + rightPlayerLives);
    }
    
    public void RightPlayerAddScore(int value)
    {
        rightPlayerScore += value;
        Debug.Log("Score = " + rightPlayerScore);
    }
    */
}
