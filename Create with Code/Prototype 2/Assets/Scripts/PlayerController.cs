using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput, speed = 10f;
    private float xRange = 10f;
    public GameObject projectilePrefab;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //keep player in bounds
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //"instantiate" creates an object; here we are creating copies of the projectilePrefab
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
    }
}
