using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;
    private Rigidbody playerRigidbody;
    private GameObject focalPoint;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRigidbody.AddForce(focalPoint.transform.forward * playerSpeed * forwardInput);
    }
}
