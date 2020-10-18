using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;
    private Rigidbody playerRigidbody;
    private GameObject focalPoint;
    public bool hasPowerup;
    private float powerupStrength = 15f;
    public GameObject powerupIndicator;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdown());
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.transform.position - transform.position;
            enemyRb.AddForce(powerupStrength * awayFromPlayer, ForceMode.Impulse);
            Debug.Log("Player collided with" + other.gameObject + " with powerup set to " + hasPowerup);
        }
    }

    IEnumerator PowerupCountdown()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRigidbody.AddForce(focalPoint.transform.forward * playerSpeed * forwardInput);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.65f, 0);
    }
}
