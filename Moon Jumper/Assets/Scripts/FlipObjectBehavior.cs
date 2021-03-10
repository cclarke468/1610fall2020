using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObjectBehavior : MonoBehaviour
{
    public float rotateValue;
    // private Vector3 rotateVector;

    private void Update()
    {
        // rotateVector.y = rotateValue;
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            rotateValue = -90;
        }
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            rotateValue = 90;
        }
        transform.rotation = Quaternion.Euler(0,rotateValue,0);
    }
}
