using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Maxvalue = 3.0f;
    public float value;

    private void Start()
    {
        value = Maxvalue;
    }
    public void Update()
    {
        Debug.Log(value);
    }

    public void DealDamage(float Damage)
    {
        value -= Damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
