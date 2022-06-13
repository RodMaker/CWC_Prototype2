using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Horizontal Input
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    // Vertical Input
    public float verticalInput;
    public float verticalSpeed = 10.0f;
    public float topZRange = 5.0f;
    public float lowZRange = -1.5f;

    // Projectile
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Limits the movement on the x axis
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Limits the movement on the z axis
        if (transform.position.z < lowZRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, lowZRange);
        }

        if (transform.position.z > topZRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topZRange);
        }

        // Moves the player horizontaly
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Moves the player verticaly
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * verticalSpeed);

        // Checks for input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Fires a projectile
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
    }
    
    /*void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over!");
        Destroy(gameObject);
        Destroy(other.gameObject);
    }*/
}
