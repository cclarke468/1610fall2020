using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float jumpForce = 10f;
    private float gravityModifier = 1f; 
    void Start()
    {
        //in order to access components of Rigidbody (like "transform._____") we have to use code
        playerRigidbody = GetComponent<Rigidbody>();
        //now we can access stuff inside Rigidbody, like "AddForce"
            // playerRigidbody.AddForce(Vector3.up * 1000);
        Physics.gravity *= gravityModifier;
        //this statement accesses the game's physics...now we can mess with Unity's gravity
    }

    private bool isOnGround = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            //ForceMode has 4 types of forces; impulse applies the wanted force immediately instead of over time, which is the default
            isOnGround = false;
        }
    }
    //to tell when player collides with the ground, or another object...
    private void OnCollisionEnter(Collision other)
    {
        isOnGround = true;
    }
}
