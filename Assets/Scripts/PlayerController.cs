using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Gravity = 9.8f;
    public float Speed = 0.0f;

    private Vector3 _moveVector;
    private float _fallVelocity = 0.0f;

    private CharacterController _characterController;

    void Start()
    {
        GetWhatsNeeded();
    }
    void Update()
    {
        MovementControllsUpdate();
        AnimationControls();
    }
    void FixedUpdate()
    {
        MovementFixedUpdate();
    }

    private void GetWhatsNeeded()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void MovementControllsUpdate()
    {
        _moveVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _moveVector += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveVector -= transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;
        }
    }

    private void MovementFixedUpdate()
    {
        _characterController.Move(_moveVector * Speed * Time.fixedDeltaTime);

        _fallVelocity += Gravity * Time.deltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }

    private void AnimationControls()
    {
        Vector3 mousePosition = new Vector3()
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };
        Vector3 point = Camera.main.ScreenToWorldPoint(mousePosition);
        //Debug.Log($"mouse: {mousePosition}");
        //Debug.Log($"world: {point}");
    }
}
