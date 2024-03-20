using UnityEngine;
using UnityEngine.Events;

public class FoodsReloader : MonoBehaviour
{
    [SerializeField] private UnityEvent _reloading;

    public float Delay = 1.0f;

    private bool _inTrigger = false;
    private float _time = 0;

    private void Update()
    {
        Event();
        DelayTiming();
    }

    private void Event()
    {
        if (Input.GetKeyDown(KeyCode.E) && _inTrigger && _time > Delay)
        {
            _reloading.Invoke();
            _time = 0;
        }
        else
        {
            return;
        }
    }
    private void DelayTiming()
    {
        _time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerConroller))
        {
            _inTrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerConroller))
        {
            _inTrigger = false;
        }
    }
}
