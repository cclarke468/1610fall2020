using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float resetPos;

    private void Start()
    {
        startPosition = transform.position; //set background position to it's current position
        resetPos = GetComponent<BoxCollider>().size.x / 2;
        print(resetPos);
        //use box collider to measure width of background, so get the box collider's width (x) and divide by 2
        //now we know exactly when to repeat
    }

    private void Update()
    {
        //make background reset to start position once it passes reset point
        if (transform.position.x < startPosition.x - resetPos)
        {
            transform.position = startPosition;
        }
    }
}
