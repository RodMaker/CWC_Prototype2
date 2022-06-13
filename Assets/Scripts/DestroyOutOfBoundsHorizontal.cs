using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsHorizontal : MonoBehaviour
{
    private float leftBound = -25;
    private float rightBound = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
