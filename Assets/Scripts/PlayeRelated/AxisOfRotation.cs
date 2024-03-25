using UnityEngine;

public class AxisOfRotation : MonoBehaviour
{
    public Animator Animator;

    void Update()
    {
        Rotation();
        AnimationHandler();
    }

    private void Rotation()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(targetPosition);
        }
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
