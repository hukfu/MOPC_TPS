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
    private void OnCollisionEnter(Collision collision)
    {
        AttackUpdate(collision);
    }

    private void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void ChaseUpdate()
    {
        _navMeshAgent.destination = Player.transform.position;
    }

    private void AttackUpdate(Collision collision)
    {
        var PlayerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (PlayerHealth != null)
        {
            PlayerHealth.DealDamage(PlayerHealth.Maxvalue);
        }
    }
}
