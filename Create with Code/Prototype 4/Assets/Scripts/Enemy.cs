using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;
    private Rigidbody enemyRigidbody;
    private GameObject player;
    private int bottomBound = -10;

    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(lookDirection * enemySpeed);
        //(player position - enemy position)at a consistent speed * enemySpeed
        
        if (transform.position.y <= bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
