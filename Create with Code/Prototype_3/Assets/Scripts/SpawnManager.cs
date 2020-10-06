﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    private float startDelay = 2f, repeatRate = 1.5f;

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }
}
