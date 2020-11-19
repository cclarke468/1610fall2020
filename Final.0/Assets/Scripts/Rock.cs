using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Rock : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    public ParticleSystem explosionParticle;
    public GlobalData globalData;
    void Start()
    {
        targetRb = gameObject.GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (gameObject.CompareTag("Rock")) //REPLACE TAG with better identification system
        {
            gameManager.UpdateScore(3);
            print("rock");
        }
    }
    void Update()
    {
        
    }
}
