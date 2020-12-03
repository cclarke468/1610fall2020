using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Rock : MonoBehaviour
{
    private GameManager gameManager;
    public ParticleSystem explosionParticle;
    public GlobalData globalData;
    public int pointValue;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Rock") && globalData.gameStarted) //REPLACE TAG with better identification system
        {
            explosionParticle.Play(); //not working
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
            print("rock worth "+pointValue+" points");
        }
    }
    void Update()
    {
        
    }
}
