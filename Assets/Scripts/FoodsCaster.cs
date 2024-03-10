using UnityEngine;

public class FoodsCaster : MonoBehaviour
{
    public Foods FoodsPrefab;
    public float RotationSpeed = 1.0f;

    public float MaxAngle = 90.0f;

    void Update()
    {
        var newAngleX = transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X");
        if (newAngleX > 180)
        {
            newAngleX -= 360;
        }

        newAngleX = Mathf.Clamp(newAngleX, -MaxAngle, MaxAngle);
        transform.rotation = Quaternion.Euler(0, newAngleX, 0);

        Debug.Log(transform.eulerAngles);

        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(FoodsPrefab, transform.position, transform.rotation);
        }
    }
}
 