﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10f;
    private float bottomBound = -5f;
    private PlayerController playerControllerScript; //referencing our own scripted class "PlayerController"
    void Start()
    {
        playerControllerScript = GameObject.Find("Player") //finds object named "Player" in hierarchy
            .GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.y < bottomBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject); //destroy obstacles passing left boundary
        }
    }
}
