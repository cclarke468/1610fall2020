using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Rock : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem explosionParticle;
    void Start()
    {
        targetRb = gameObject.GetComponent<Rigidbody>();
        
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }
    void Update()
    {
        
    }
}
