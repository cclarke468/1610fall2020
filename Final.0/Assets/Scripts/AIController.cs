using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AIController : MonoBehaviour
{
    private NavMeshAgent pursuingAgent;
    public Transform playerLocation;
    private bool canPatrol = true;
    private int i = 0;
    public List<Transform> patrolPoints;
    private void Start()
    {
        pursuingAgent = GetComponent<NavMeshAgent>();
        playerLocation = transform; //set destination to enemy (this object) to keep it from auto pursuing
    }
    
    //I think this trigger is preventing player death trigger in player controller script...enum??
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canPatrol = false;
            playerLocation = other.transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        canPatrol = true;
        playerLocation = transform;
    }
    private void Update()
    {
        pursuingAgent.destination = playerLocation.position;
        // print("enemy position: " + pursuingAgent.destination + ", player: " + playerLocation.position);
        if (!canPatrol) return;
        if (pursuingAgent.pathPending || !(pursuingAgent.remainingDistance < 0.5f)) return;
        playerLocation = patrolPoints[i];
        i = (i + 1) % patrolPoints.Count;
    }
}

