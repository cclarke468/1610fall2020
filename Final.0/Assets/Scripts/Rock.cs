using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Rock : MonoBehaviour
{
    // private Rigidbody targetRb;
    private GameManager gameManager;
    public ParticleSystem explosionParticle;
    public GlobalData globalData;
    public int pointValue;
    void Start()
    {
        // targetRb = gameObject.GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        explosionParticle.Play();
        Destroy(gameObject);
        if (gameObject.CompareTag("Rock")) //REPLACE TAG with better identification system
        {
            gameManager.UpdateScore(pointValue);
            print("rock worth "+pointValue+" points");
        }
    }
    void Update()
    {
        
    }
}
