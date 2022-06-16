using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Local Multiplayer
    public string inputID;

    // Inputs
    private float horizontalInput;
    private float verticalInput;
    private float horizontalSpeed = 20.0f;
    private float verticalSpeed = 20.0f;
    
    // Projectile
    public GameObject projectilePrefab;
    // public Transform projectileSpawnPoint; (já não é preciso)

    // Left Player (Player 1)
    // Horizontal Movement
    private float leftPlayerLeftRange = -20;
    private float leftPlayerRightRange = 0;
    // Vertical Movement
    private float leftPlayerUpZRange = 5.0f;
    private float leftPlayerDownZRange = -1.5f;

    // Right Player (Player 2)
    // Horizontal Movement
    private float rightPlayerLeftRange = 0;
    private float rightPlayerRightRange = 20;
    // Vertical Movement
    private float rightPlayerUpZRange = 5.0f;
    private float rightPlayerDownZRange = -1.5f;


    // Update is called once per frame
    void Update()
    {
        // Left Player
        if (inputID == "1")
        {
            // Check for left and right bounds, limits the movement on the x axis
            if (transform.position.x < leftPlayerLeftRange)
            {
                transform.position = new Vector3(leftPlayerLeftRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > leftPlayerRightRange)
            {
                transform.position = new Vector3(leftPlayerRightRange, transform.position.y, transform.position.z);
            }

            // Check for up and down bounds, limits the movement on the z axis
            if (transform.position.z < leftPlayerDownZRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, leftPlayerDownZRange);
            }

            if (transform.position.z > leftPlayerUpZRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, leftPlayerUpZRange);
            }
        }
        
        // Right Player
        if (inputID == "2")
        {
            // Check for left and right bounds, limits the movement on the x axis
            if (transform.position.x < rightPlayerLeftRange)
            {
                transform.position = new Vector3(rightPlayerLeftRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > rightPlayerRightRange)
            {
                transform.position = new Vector3(rightPlayerRightRange, transform.position.y, transform.position.z);
            }

            // Check for up and down bounds, limits the movement on the z axis
            if (transform.position.z < rightPlayerDownZRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, rightPlayerDownZRange);
            }

            if (transform.position.z > rightPlayerUpZRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, rightPlayerUpZRange);
            }
        }
        
        /* One Player Movement Script
        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        */

        //Two Players Movement
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput);

        if (Input.GetButtonDown("Shoot" + inputID))
        {
            // No longer necessary to Instantiate prefabs
            // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

            // Get an object object from the pool
            GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();
            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true); // activate it
                pooledProjectile.transform.position = transform.position; // position it at player
            }
        }
    }
}
