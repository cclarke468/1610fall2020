using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; 
    //new array of GameObjects
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 2f; //2 seconds
    private float spawnInterval = 1.5f; //1.5 seconds

    void SpawnRandomAnimal()
    {
        //to use to call the number of any object in the array
        int animalIndex = Random.Range(0,animalPrefabs.Length); 
        //Random is a class to call random numbers,
        //using a range (start number, number of items in range——can use the array itself)
        
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //spawn position is randomly generated for x-axis between -20 and 20, the spawnRange
        
        Instantiate(animalPrefabs[animalIndex], spawnPosition, 
            animalPrefabs[animalIndex].transform.rotation);
        //this means create new game objects from the array of animal prefabs,
        //in the location of our spawnPosition
        //and summon each of those animals at the correct rotation
    }
    
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //this invokes the Spawn Random Animal function repeatedly every 1.5 seconds (spawn interval)
    }
    
}
