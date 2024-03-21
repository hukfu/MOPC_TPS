using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Gravity = 9.8f;
    public float Speed = 0.0f;

    public Animator Animator;

    private Vector3 _moveVector;
    private float _fallVelocity = 0.0f;


    public float yOffset = 100f;

    private CharacterController _characterController;

    void Start()
    {
        GetWhatsNeeded();
    }
    void Update()
    {
        MovementControllsUpdate();
        AnimationHandler();
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

        _moveVector.x = Input.GetAxis("Horizontal");
        _moveVector.z = Input.GetAxis("Vertical");

        _moveVector = transform.rotation * _moveVector;
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

    private void AnimationHandler()
    {
        if (_moveVector.x == 0 && _moveVector.z == 0)
        {
            Animator.SetBool("IsMoving", false);
        }
        else
        {
            Animator.SetBool("IsMoving", true);
        }
    }
}
