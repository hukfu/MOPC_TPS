using UnityEngine;
using UnityEngine.AI;

public class EnemyBillboard : MonoBehaviour
{
    public Animator Animator;

    [SerializeField] private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        AnimationHandler();
    }
    private void AnimationHandler()
    {
        var angle = transform.localEulerAngles.y;
        if (angle > 202.5)
        {
            angle -= 360;
        }
        Animator.SetFloat("Angle", angle);
    }
}


