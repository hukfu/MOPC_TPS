using UnityEngine;
using UnityEngine.Events;

public class PlayerDetector : MonoBehaviour
{
    [SerializeField] private UnityEvent _onPlayerEnter;
    [SerializeField] private UnityEvent _onPlayerExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerConroller))
        {
            _onPlayerEnter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerConroller))
        {
            _onPlayerExit.Invoke();
        }
    }
}
