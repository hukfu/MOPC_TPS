using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform CameraAxisTransform;

    public float minAngle = 0.0f;
    public float maxAngle = 0.0f;

    public float RotationSpeed = 1.0f;
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);

        var newAngleX = CameraAxisTransform.localEulerAngles.x - Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y");
        if (newAngleX > 180)
            newAngleX -= 360;
        newAngleX = Mathf.Clamp(newAngleX, minAngle, maxAngle);

        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}
