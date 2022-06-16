using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Sekkinn : MonoBehaviour
{
    [SerializeField] private Transform target;
    NavMeshAgent agent;
    float moveSpeed;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        moveSpeed = agent.speed;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) < 5.0f)
        {
            agent.destination = target.position;
            agent.speed = moveSpeed;
        }
        else
        {
            agent.speed = 0;
        }
    }
}
