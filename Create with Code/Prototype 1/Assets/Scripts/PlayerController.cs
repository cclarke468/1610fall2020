using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float forwardInput;
    //fun fact: you can edit unity's input info by going to edit>project settings>input manager
    void Update()
    {
        //getting player input...
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //Time.deltaTime makes vehicle update every second instead of every frame
        
        //move vehicle forward based on forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       
        //rotates car based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);

    }
}
