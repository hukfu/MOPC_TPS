using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public PlayerController Player;

    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        InitComponentLinks();
    }
    private void Update()
    {
        ChaseUpdate();
    }

    private void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void ChaseUpdate()
    {
        _navMeshAgent.destination = Player.transform.position;
    }
}
