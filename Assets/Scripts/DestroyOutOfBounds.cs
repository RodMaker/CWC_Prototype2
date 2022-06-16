using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Vertical Bounds
    private float topBound = 30;
    private float lowerBound = -10;
    // Horizontal Bounds
    private float leftBound = -30;
    private float rightBound = 30;
    // External references
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Instead of destroying the game object, deactivate it
        if (transform.position.z > topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < lowerBound) 
        {
            gameManager.AddLives(-1);
            gameObject.SetActive(false);
        }
        else if (transform.position.x > rightBound)
        {
            gameManager.AddLives(-1);
            gameObject.SetActive(false);
        }
        else if (transform.position.x < leftBound) 
        {
            gameManager.AddLives(-1);
            gameObject.SetActive(false);
        }

    }
}
