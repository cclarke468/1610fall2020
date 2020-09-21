using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    void Start()
    {
        
    }
    
    void Update()
    {
        //Move vehicle forward
        //transform.Translate(0,0,1); OR...
        //transform.Translate(Vector3.forward);
        //transform.Translate(Vector3.forward * Time.deltaTime * 20); //Time.deltatime makes vehicle update every second instead of every frame (like Update() does)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
