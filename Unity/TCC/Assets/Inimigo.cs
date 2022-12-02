using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Inimigo : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;
    Vector3 direction;
    float debug;
    public PlayerMovement player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        SetTarget();
        SetDirection();
        SetDano();
    }

    void SetTarget()
    {
        if (target != null)
            agent.SetDestination(target.position);
    }

    void SetDirection()
    {
        direction = agent.desiredVelocity;
    }

    void SetDano()
    {
        player.SetAtaque(debug);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Player":
                debug = 1;
                break;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        debug = 0;
    }

}
