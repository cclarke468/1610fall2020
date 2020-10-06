using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30f;
    private float bottomBoundary = -20f;
    void Update()
    {
        //delete object once it passes out of bounds
        //FYI: transform.position accesses the position of the object this script is applied to
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
            //"gameObject" is the object this script is applied to
        }
        else if (transform.position.z < bottomBoundary)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
            //give "Game Over" message in console if any animal passes bottom boundary
        }
    }
}
