using UnityEngine;

public class FoodsCaster : MonoBehaviour
{
    public Foods FoodsPrefab;
    public float Delay = 1.0f;

    private float _time = 0;

    private void Update()
    {
        _time += Time.deltaTime;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_time > Delay)
                {
                    Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                    Foods food = Instantiate(FoodsPrefab, transform.position, transform.rotation);
                    food.transform.LookAt(targetPosition);
                    _time = 0;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
