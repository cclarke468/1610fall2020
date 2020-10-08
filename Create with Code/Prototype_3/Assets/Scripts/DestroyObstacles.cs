using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float startPos;

    private void Start()
    {
        startPos = obstaclePrefab.transform.position.x;
    }

    void Update()
    {
        if (obstaclePrefab.transform.position.x < startPos - 10)
        {
            Destroy(obstaclePrefab);
        }
    }
}
