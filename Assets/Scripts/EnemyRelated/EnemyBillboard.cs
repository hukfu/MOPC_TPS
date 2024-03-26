using UnityEngine;
using UnityEngine.AI;

public class EnemyBillboard : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        //_agent.updateRotation = false;
    }

    private void Update()
    {
        Vector3 nextPosition3 = _agent.nextPosition;
        Vector3 nextPosition2 = new Vector2(nextPosition3.x, nextPosition3.z);
        Vector2 cameraLookDirection = new Vector2(0, -1.0f);
        float angle = Vector2.Angle(cameraLookDirection, nextPosition2);
        Debug.Log(angle);
    }
}


