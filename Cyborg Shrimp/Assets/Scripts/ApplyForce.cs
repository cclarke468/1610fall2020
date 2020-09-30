using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody rBody;
    public float force = 500f;
    void Start()
    {
        //rBody.AddForce(0, force, 0);
        //this applies force once when you start the game
    }
    void Update()
    {
        //rBody.AddForce(0, force, 0);
        //this applies constantly during game
    }
    void OnMouseDown()
    {
        rBody.AddForce(0, force, 0);
        //this applies force once when you click on it
    }
}

