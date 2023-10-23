using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints; // Array to store patrol points
    private int currentPatrolPointIndex = 0;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetDestinationToNextPatrolPoint();
    }

    void Update()
    {
        // Check if the enemy has reached its current patrol point
        if (agent.remainingDistance < 0.1f)
        {
            SetDestinationToNextPatrolPoint();
        }
    }

    void SetDestinationToNextPatrolPoint()
    {
        // Set the enemy's destination to the next patrol point
        agent.SetDestination(patrolPoints[currentPatrolPointIndex].position);

        // Increment the index to move to the next patrol point
        currentPatrolPointIndex = (currentPatrolPointIndex + 1) % patrolPoints.Length;
    }
}

