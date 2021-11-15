using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5;

    NavMeshAgent navMeshAgent;
    float distanceToEnemy = Mathf.Infinity;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distanceToEnemy = Vector3.Distance(transform.position, target.position);
        if (distanceToEnemy <= chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }
}
