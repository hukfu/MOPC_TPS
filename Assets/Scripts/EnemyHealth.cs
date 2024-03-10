using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 1.0f;

    public void DealDamage(float Damage)
    {
        value -= Damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
