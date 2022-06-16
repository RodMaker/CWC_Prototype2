using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        /* 
        Object Pooling
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 

        // Just deactivate the food and destroy the animal
        other.gameObject.SetActive(false);
        Destroy(gameObject);
        */

        /*
        if(other.CompareTag("Player1"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(other.CompareTag("Player2"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(other.CompareTag("Dog"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
        */

        if(other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(other.CompareTag("Dog"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
    }

}
