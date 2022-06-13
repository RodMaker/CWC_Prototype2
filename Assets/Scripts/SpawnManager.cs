using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Vertical Spawn Position
    private float spawnRangeX = 10.0f;
    private float spawnPosX;
    private float spawnPosY = 0;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public GameObject[] leftAnimalPrefabs;
    //Horizontal Left Spawn Position
    private float leftSpawnRangeZ = 10.0f;
    private float leftSpawnPosX = -20.0f;
    private float leftSpawnPosY = 0;
    private float leftSpawnPosZ;
    private float leftStartDelay = 2;
    private float leftSpawnInterval = 1.5f;

    public GameObject[] rightAnimalPrefabs;
    //Horizontal Right Spawn Position
    private float rightSpawnRangeZ = 10.0f;
    private float rightSpawnPosX = 20.0f;
    private float rightSpawnPosY = 0;
    private float rightSpawnPosZ;
    private float rightStartDelay = 2;
    private float rightSpawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        /*OLD CODE
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }*/
    }

    void SpawnRandomAnimal()
    {
        // Vertical Spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        // Horizontal Left Spawn
        leftSpawnPosZ = Random.Range(-1.5f, leftSpawnRangeZ);
        Vector3 leftSpawnPos = new Vector3(leftSpawnPosX, leftSpawnPosY, leftSpawnPosZ);
        Instantiate(leftAnimalPrefabs[animalIndex], leftSpawnPos, leftAnimalPrefabs[animalIndex].transform.rotation);

        // Horizontal Right Spawn
        rightSpawnPosZ = Random.Range(-1.5f, rightSpawnRangeZ);
        Vector3 rightSpawnPos = new Vector3(rightSpawnPosX, rightSpawnPosY, rightSpawnPosZ);
        Instantiate(rightAnimalPrefabs[animalIndex], rightSpawnPos, rightAnimalPrefabs[animalIndex].transform.rotation);
    }
}
