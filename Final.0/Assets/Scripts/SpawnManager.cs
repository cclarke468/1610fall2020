using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    private float startDelay = 2f, repeatRate = 1.5f;
    public GlobalData gameOver; //NEW global data script with bool
    // private PlayerController playerControllerScript;

    void SpawnObstacle()
    {
        // if (playerControllerScript.gameOver == false)
        // {
        //     Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        // }
        if (!gameOver.gameOverBool)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        gameOver.gameOverBool = false;
        // playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
}
